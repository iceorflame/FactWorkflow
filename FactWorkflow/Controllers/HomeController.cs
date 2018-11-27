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
using Microsoft.AspNetCore.Http;
using System.IO;

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

        [HttpGet]
        public IActionResult AddDocument()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDocument(Document document, Models.File file, Resolve resolve, IFormFile uploadFile, int classification)
        {
            _context.Documents.Add(document);
            _context.SaveChanges();

            if(uploadFile != null)
            {
                byte[] imageData = null;
                using (var binaryReader = new BinaryReader(uploadFile.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)uploadFile.Length);
                }
                file.FByte = imageData;
                file.FName = uploadFile.FileName;
                file.FType = uploadFile.ContentType;
                _context.Files.Add(file);
                document.FId = file.FId;
            }
            document.DDate = DateTime.Now;
            document.DIndex = document.DId+"/"+classification+"/1.9";
            //_context.Documents.Add(document);
            _context.Entry(document).State = EntityState.Modified;

            resolve.DId = document.DId;
            User user = _context.Users.FirstOrDefault(u => u.RId == 4);
            resolve.UId = user.UId;
            resolve.RAddress = user.UName;
            resolve.RStatus = "На підтвердженні у ректора";
            _context.Resolves.Add(resolve);
            _context.SaveChanges();

            return RedirectToAction("AddDocument","Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
