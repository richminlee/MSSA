using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int? counter = HttpContext.Session.GetInt32("count");
            if(counter == null)
            {
                counter = 0;
            }
            counter++;
            ViewModel numbers = new ViewModel();
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            numbers.RandomAlphaNumeric = "";
            for (int i = 0; i < 14; i++)
            {
                numbers.RandomAlphaNumeric += chars[random.Next(0,36)];
            }
            HttpContext.Session.SetInt32("count", (int)counter);
            numbers.counter = HttpContext.Session.GetInt32("count");
            return View("Index", numbers);
        }
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
