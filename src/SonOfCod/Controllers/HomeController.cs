using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SonOfCod.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewsLetter()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Subscribe(SubscriberViewModel model)
        //{
        //    var subscriber = new ApplicationUser { UserName = model.Email };
        //    IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        //    if (result.Succeeded)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
    }
}
