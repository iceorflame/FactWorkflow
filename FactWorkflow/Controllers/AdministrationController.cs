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

        public IActionResult TokenTable()
        {
            var tokens = _context.Tokens.OrderByDescending(x => x.TId);
            return View(tokens.ToList());
        }
    }
}