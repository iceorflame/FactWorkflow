using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FactWorkflow.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FactWorkflow.Controllers
{
    public class HomeController : Controller
    {
        private readonly WorkflowContext _context;
        public HomeController(WorkflowContext context)
        {
            _context = context;
        }

        public string MD5Hash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Encoding.UTF8.GetString(result);
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult DataChange()
        {
            User user = _context.Users.FirstOrDefault(u => u.UMail == HttpContext.User.Identity.Name);
            return View(user);
        }

        [HttpPost]
        [Authorize]
        public IActionResult DataChange(User user, string newPassword, string confirmPassword)
        {
            if (newPassword == null || confirmPassword == null)
            {
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else if (newPassword == confirmPassword && newPassword != null && confirmPassword != null)
            {
                user.UPassword = MD5Hash(newPassword);
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return RedirectToAction("DataChange", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
