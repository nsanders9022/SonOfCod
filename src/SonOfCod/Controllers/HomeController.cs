using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.ViewModels;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;

namespace SonOfCod.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewsLetter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewsLetter(Subscriber subscriber)
        {
            db.Subscribers.Add(subscriber);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult List()
        {
            return View(db.Subscribers.ToList());
        }
            
    }
}
