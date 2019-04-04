﻿using System;
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
        [Authorize(Roles = "office,rector,vrector,dean,cathedra,admin")]
        public IActionResult Index()
        {
            ViewBag.Active = "Index";
            if (HttpContext.User.IsInRole("admin"))
            {
                return RedirectToAction("TokenTable", "Administration");
            }
            else if (HttpContext.User.IsInRole("office"))
            {
                return RedirectToAction("Office", "Home");
            }
            else if (HttpContext.User.IsInRole("rector"))
            {
                var document2 = _context.Histories.Where(r => r.SId == 1).Include(d => d.Document.File).Include(s => s.Status).Include(t => t.Type);
                return View(document2);
            }
            var documents = _context.Histories.Where(r => r.SId == 5 && r.User.UMail == HttpContext.User.Identity.Name).Include(d => d.Document.File).Include(s => s.Status).Include(t => t.Type);
            return View(documents);
        }

        [HttpGet]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra,admin")]
        public IActionResult Office()
        {
            ViewBag.Active = "Index";
            var documents = _context.Resolves.Include(d => d.Document.File).Include(s => s.Status).Where(s => s.SId == 3);
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
            ViewBag.Active = "AddDocument";
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult AddDocument(AddDocument addDocument, Document document, Models.File file, History history, IFormFile uploadFile, int classification)
        {
            if (uploadFile != null)
            {
                User user = _context.Users.FirstOrDefault(u => u.RId == 4);
                if(user != null)
                {
                    if (ModelState.IsValid)
                    {
                        document.DAbout = addDocument.DocumentAbout;
                        document.DFrom = addDocument.DocumentFrom;
                        _context.Documents.Add(document);
                        _context.SaveChanges();

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
                        document.DDate = DateTime.Now;
                        document.DIndex = document.DId + "/" + classification + "/1.9";
                        _context.Entry(document).State = EntityState.Modified;

                        history.DId = document.DId;
                        history.TId = 1;
                        history.UId = user.UId;
                        history.HAddress = user.UName;
                        history.SId = 1;
                        _context.Histories.Add(history);
                        _context.SaveChanges();
                    }
                    else
                    {
                        ViewData["Message"] = "Text";
                        return View();
                    }

                }
                else
                {
                    ViewData["Message"] = "Rector";
                    return View();
                }

            }
            else {
                ViewData["Message"] = "File";
                return View();
            }

            //return RedirectToAction("DocumentTable","Home");
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult DocumentTable()
        {
            if (HttpContext.User.IsInRole("rector") || HttpContext.User.IsInRole("office"))
            {
                var histories = _context.Histories.Include(u => u.User).Include(d => d.Document.File).Include(s => s.Status).Include(t => t.Type).Where(x => x.SId > 4);
                return View(histories);
            }
            var documents = _context.Histories.Where(r => r.SId > 4 && r.User.UMail == HttpContext.User.Identity.Name).Include(d => d.Document.File).Include(s => s.Status).Include(t => t.Type);
            return View(documents);
        }

        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult ChangeStatus(int hid)
        {
            History history = _context.Histories.Find(hid);
            if (history.TId == 1)
            {
                history.SId = 6;
            }
            else
            {
                history.SId = 7;
            }
            _context.Entry(history).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult AddResolve(int hid)
        {
            //Resolve resolve = _context.Resolves.Find(resid);
            //resolve.RAddress = "";
            History history = _context.Histories.Include(d => d.Document).FirstOrDefault(h => h.Hid == hid);
            Resolve resolve = new Resolve();
            AddResolve addResolve = new AddResolve { History=history, Resolve = resolve };
            return View(addResolve);
        }

        [HttpPost]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult AddResolve(AddResolve addResolve)
        {
            addResolve.History.SId = 2;
            _context.Resolves.Add(new Resolve { DId = addResolve.History.DId, RText = addResolve.Resolve.RText, SId = 3 });
            _context.Entry(addResolve.History).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult SendResolve(int resid)
        {
            Resolve resolve = _context.Resolves.Find(resid);
            var histories = _context.Histories.Include(t => t.Type).Where(r => r.SId > 4);
            SendResolve sendResolve = new SendResolve { Resolve = resolve, Histories = histories };
            return View(sendResolve);
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
        public IActionResult SendResolve(int resid, int optradio,int roleSelect, int userSelect, string userName, DateTime dateSelect, bool rOriginal, bool rResponsible)
        {
            string u;
            Resolve resolve = _context.Resolves.Find(resid);
            if(roleSelect != 7)
            {
                User user = _context.Users.Find(userSelect);
                u = user.UName;
            }
            else
            {
                u = userName;
            }

            if (optradio == 1)
            {
                _context.Histories.Add(new History { TId = 1, DId = resolve.DId, UId = userSelect, HAddress = u, HOriginal=rOriginal,HResponsible=rResponsible, SId = 5 });
            }
            else
            {
                _context.Histories.Add(new History { TId = 2, DId = resolve.DId, UId = userSelect, HAddress = u, HDate = dateSelect.Date, HOriginal = rOriginal, HResponsible = rResponsible, SId = 5 });
            }
            _context.SaveChanges();
            var histories = _context.Histories.Include(t => t.Type).Where(r => r.SId > 4);
            SendResolve sendResolve = new SendResolve { Resolve = resolve, Histories = histories };
            return View(sendResolve);
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

        public IActionResult ConfirmResolve(int rid)
        {
            Resolve resolve = _context.Resolves.Find(rid);
            resolve.SId = 4;
            _context.Entry(resolve).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Office", "Home");
        }

        public IActionResult DeleteHistory(int hid, int rid)
        {
            History history = _context.Histories.Find(hid);
            _context.Histories.Remove(history);
            _context.SaveChanges();
            Resolve resolve = _context.Resolves.Find(rid);
            var histories = _context.Histories.Include(t => t.Type).Where(r => r.SId > 4);
            SendResolve sendResolve = new SendResolve { Resolve = resolve, Histories = histories };
            return RedirectToAction("SendResolve", "Home", new { resid = rid });
        }

        public IActionResult ApplyWork(int did)
        {
            var history = _context.Histories.Where(d => d.DId == did && d.SId > 4);
            foreach (var item in history)
            {
                item.SId = 8;
                _context.Entry(item).State = EntityState.Modified;
            }
            _context.SaveChanges();
            return RedirectToAction("DocumentTable", "Home");
        }


    }
}
