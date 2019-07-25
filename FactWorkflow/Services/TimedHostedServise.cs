using FactWorkflow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FactWorkflow.Services
{
    internal class TimedHostedService : IHostedService, IDisposable
    {
        private Timer _timer;
        private readonly IServiceScopeFactory scopeFactory;

        public TimedHostedService(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromHours(1));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            if ((DateTime.Now.Hour >= 1) && (DateTime.Now.Hour <= 2))
            {
                using (var scope = scopeFactory.CreateScope())
                {
                    var _context = scope.ServiceProvider.GetRequiredService<WorkflowContext>();
                    var historyList = _context.Histories.Where(r => r.TId == 2);
                    foreach (var item in historyList)
                    {
                        if ((item.HDate <= DateTime.Now.Date) && (item.SId != 8))
                        {
                            item.SId = 11;
                        }
                    }
                    _context.SaveChanges();
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
