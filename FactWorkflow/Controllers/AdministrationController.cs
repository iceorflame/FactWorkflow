using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactWorkflow.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [Authorize(Roles = "admin")]
        public IActionResult TokenTable()
        {
            var tokens = _context.Tokens.OrderByDescending(x => x.TId);
            return View(tokens.ToList());
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
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

        [HttpGet]
        //[Authorize(Roles = "admin")]
        public IActionResult UserTable()
        {
            ViewBag.Active = "usertable";
            var users = _context.Users.Include(u => u.Role).OrderByDescending(x => x.UId);
            return View(users.ToList());
        }


        public IActionResult DeleteUser(int? id)
        {
            User user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            return RedirectToAction("UserTable", "Administration");
        }

        [HttpGet]
        public IActionResult EditUser(int? id)
        {
            User user = _context.Users.Find(id);
            if (user != null)
            {
                SelectList roles = new SelectList(_context.Roles, "RId", "RAlterName", user.RId);
                ViewBag.Roles = roles;
                return View(user);
            }
            return RedirectToAction("UserTable", "Administration"); 
        }

        [HttpPost]
        public IActionResult EditUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("UserTable", "Administration");
        }
    }
}