﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.ViewModels;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace SonOfCod.Controllers
{
    public class Marketing : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {
            return View(db.Content.ToList());
        }

        public IActionResult Edit(int id)
        {
            var thisContent = db.Content.FirstOrDefault(content => content.ContentId == id);
            return View(thisContent);
        }

        [HttpPost]
        public IActionResult Edit(Content content)
        {
            db.Entry(content).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
