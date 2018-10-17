using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FactWorkflow.Models;

namespace FactWorkflow.Controllers
{
    public class AccountController : Controller
    {
        private readonly WorkflowContext _context;
        public AccountController(WorkflowContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}