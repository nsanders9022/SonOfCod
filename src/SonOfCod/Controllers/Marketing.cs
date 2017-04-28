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
    public class Marketing : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
