using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FactWorkflow.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using System.Text;
using System.Security.Cryptography;
using FactWorkflow.Services;

namespace FactWorkflow.Controllers
{
    public class AccountController : Controller
    {
        private readonly WorkflowContext _context;
        public AccountController(WorkflowContext context)
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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.UMail == model.Email && u.UPassword == MD5Hash(model.Password));
                if (user != null)
                {
                    await Authenticate(user);

                    if (user.UMail == "factworkflow@gmail.com")
                    {
                        return RedirectToAction("TokenTable", "Administration");
                    }

                    return RedirectToAction("Index", "Home");
                }
                
            }
            ViewData["Message"] = "true";
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register (RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Token token = await _context.Tokens.FirstOrDefaultAsync(u => u.TToken == model.Token);
                if (token != null)
                {
                    User user = await _context.Users.FirstOrDefaultAsync(u => u.UMail == model.Email);
                    if (user == null)
                    {
                        if (model.Password == model.ConfirmPassword)
                        {
                            _context.Users.Add(new User { UMail = model.Email, UPassword = MD5Hash(model.Password), UName = model.Name, RId = 2 });
                            _context.Tokens.Remove(token);
                            await _context.SaveChangesAsync();

                            //EmailService emailService = new EmailService();
                            //await emailService.SendEmailAsync(model.Email, "Вас вітає СЕД Факт!", "Ви зареєструвалися в системі електронного документообігу Факт.");

                            //await Authenticate(user);

                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            ViewData["Message"] = "Password";
                        }
                    }
                    else
                    {
                        ViewData["Message"] = "User";
                    }
                }
                else
                    ViewData["Message"] = "Token";
            }
            return View(model);
        }

        private async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.UMail),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.RName)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "FactWorkflowCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}