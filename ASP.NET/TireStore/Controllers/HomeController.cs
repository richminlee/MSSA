using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TireStore.Models;

namespace TireStore.Controllers
{
    public class HomeController: Controller
    {
        TireDbContext myCtx;
        public HomeController ( TireDbContext context )
        {
            myCtx = context;
        }
        public IActionResult Index()
        {
            List<Tire> inventory;
            inventory = myCtx.Tires.ToList();
            return View("Index", inventory);
        }
    }
}
