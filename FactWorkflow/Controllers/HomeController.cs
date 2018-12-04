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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

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

        [HttpGet]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult Index()
        {
            if (HttpContext.User.IsInRole("office"))
            {
                var doc1 = _context.Resolves.Where(r => r.RStatus == "Очікує відправки").Include(d => d.Document);
                return View(doc1);
            }
            if (HttpContext.User.IsInRole("rector"))
            {
                var doc1 = _context.Resolves.Where(r => r.RStatus == "На підтвердженні у ректора").Include(d => d.Document);
                return View(doc1);
            }
            var documents = _context.Resolves.Where(r => r.RStatus == "Не переглянуто" && r.User.UMail == HttpContext.User.Identity.Name).Include(d => d.Document);
            return View(documents);
        }

        [HttpGet]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult DataChange()
        {
            User user = _context.Users.FirstOrDefault(u => u.UMail == HttpContext.User.Identity.Name);
            return View(user);
        }

        [HttpPost]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
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
        [Authorize(Roles = "office")]
        public IActionResult AddDocument()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
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
            _context.Entry(document).State = EntityState.Modified;

            resolve.DId = document.DId;
            User user = _context.Users.FirstOrDefault(u => u.RId == 4);
            resolve.UId = user.UId;
            resolve.RAddress = user.UName;
            resolve.RStatus = "На підтвердженні у ректора";
            _context.Resolves.Add(resolve);
            _context.SaveChanges();

            return RedirectToAction("DocumentTable","Home");
        }

        [HttpGet]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult DocumentTable()
        {
            var resolves = _context.Resolves.Include(u => u.User).Include(d=>d.Document.File);
            return View(resolves);
        }

        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult ChangeStatus(int? did, int? uid)
        {
            Resolve resolve = _context.Resolves.Find(did, uid);
            if (resolve != null)
            {
                resolve.RStatus = "Документ переглянуто";
                _context.Entry(resolve).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return RedirectToAction("DocumentTable", "Home");
        }

        [HttpGet]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult AddResolve(int? did, int? uid)
        {
            Resolve resolve = _context.Resolves.Find(did, uid);
            resolve.RAddress = "";
            return View(resolve);
        }

        [HttpPost]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult AddResolve(Resolve resolve)
        {
            User user = _context.Users.FirstOrDefault(x => x.RId == 3);
            resolve.UId = user.UId;
            resolve.RStatus = "Очікує відправки";
            _context.Resolves.Add(resolve);
            _context.SaveChanges();
            return RedirectToAction("DocumentTable","Home");
        }

        [HttpGet]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult SendResolve(int? did, int? uid)
        {
            Resolve resolve = _context.Resolves.Find(did, uid);
            return View(resolve);
        }

        [HttpGet]

        public IActionResult GetRoles()
        {
            var roles = _context.Roles.Where(x => x.RId > 4).ToList();
            return new ObjectResult(roles);
        }

        [HttpGet]
        public IActionResult GetUsers(int? id)
        {
            var users = _context.Users.Where(x => x.RId == id).Select(x => new DTOUser(x)).ToList();
            return new ObjectResult(users);
        }

        [HttpPost]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult SendResolve(int docid, string ra, DTOUser[] users)
        {
            User user = _context.Users.FirstOrDefault(x => x.RId == 3);
            Resolve r = _context.Resolves.Find(docid,user.UId);
            _context.Entry(r).State = EntityState.Deleted;

            for (int i = 0; i < users.Length; i++)
            {
                _context.Resolves.Add(new Resolve { DId = docid, UId = users[i].UId, RAddress = users[i].UName, RStatus = "Не переглянуто" });
            }
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public FileResult Download(int? id)
        {

            Models.File file = _context.Files.Find(id);
            return File(file.FByte, file.FType, file.FName);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
