using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginRegistration.Models;

namespace LoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(ViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpPost("login")]
        public IActionResult Login(ViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("result")]
        public IActionResult Result()
        {
            return View();
        }
    }
}
