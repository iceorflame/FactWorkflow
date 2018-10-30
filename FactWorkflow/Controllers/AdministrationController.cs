using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactWorkflow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FactWorkflow.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly WorkflowContext _context;
        public AdministrationController(WorkflowContext context)
        {
            _context = context;
        }

        private static Random random = new Random();
        public static string RandomString(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [HttpGet]
        public IActionResult TokenTable()
        {
            var tokens = _context.Tokens.OrderByDescending(x => x.TId);
            return View(tokens.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> TokenTable(int tokenCount)
        {
            for (int i=0;i < tokenCount; i++)
            {
                string tokens = RandomString();
                Token token = await _context.Tokens.FirstOrDefaultAsync(u => u.TToken == tokens);
                if (token == null)
                {
                    _context.Tokens.Add(new Token { TToken = tokens });
                }
                else
                {
                    i--;
                    continue;
                }
            }
            await _context.SaveChangesAsync();
            return TokenTable();
        }
    }
}