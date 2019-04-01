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
                var document1 = _context.Histories.Where(r => r.SId == 2).Include(d => d.Document.File).Include(s => s.Status).Include(t => t.Type);
                return View(document1);
            }
            else if (HttpContext.User.IsInRole("rector"))
            {
                var document2 = _context.Histories.Where(r => r.SId == 1).Include(d => d.Document.File).Include(s => s.Status).Include(t => t.Type);
                return View(document2);
            }
            //var documents = _context.Resolves.Where(r => r.RStatus == "Не переглянуто" && r.User.UMail == HttpContext.User.Identity.Name).Include(d => d.Document);
            return View();
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
            //if (HttpContext.User.IsInRole("rector") || HttpContext.User.IsInRole("office"))
            //{
            //    var resolves = _context.Resolves.Include(u => u.User).Include(d => d.Document.File).Where(x => x.User.RId > 4);
            //    return View(resolves);
            //}
            //var resolves2 = _context.Resolves.Include(u => u.User).Include(d => d.Document.File).Where(x => x.User.UMail == HttpContext.User.Identity.Name);
            return View();
        }

        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult ChangeStatus(int? did, int? uid)
        {
            Resolve resolve = _context.Resolves.Find(did, uid);
            if (resolve != null)
            {
                //resolve.RStatus = "Документ переглянуто";
                _context.Entry(resolve).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = "office,rector,vrector,dean,cathedra")]
        public IActionResult AddResolve(int hid)
        {
            //Resolve resolve = _context.Resolves.Find(resid);
            //resolve.RAddress = "";
            History history = _context.Histories.Find(hid);
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
        public IActionResult SendResolve(int resid, int optradio, int userSelect, string userName, DateTime dateSelect, int rOriginal, int rResponsible)
        {
            Resolve resolve = _context.Resolves.Find(resid);

            if (optradio == 1)
            {
                _context.Histories.Add(new History { TId = 1, DId = resolve.DId, UId = userSelect, HAddress = userName, SId = 5 });
            }
            else
            {
                _context.Histories.Add(new History { TId = 2, DId = resolve.DId, UId = userSelect, HAddress = userName, HDate = dateSelect.Date, SId = 7 });
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

        
    }
}
