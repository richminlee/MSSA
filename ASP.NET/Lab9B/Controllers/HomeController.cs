using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Lab9B.Models;
namespace Lab9B.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index1() 
        {
            return View(new string[] { "C#", "Language", "Features" });
        }
        public ViewResult Index2()
        {
            List<string> results = new List<string>();
            foreach ( Product p in Product.GetProducts())
            {
                string name = p?.Name?? "<No Name>";
                decimal? price = p?.Price?? 0;
                string relatedName = p?.Related?.Name?? "<None>";
                results.Add(string.Format($"Name: {name}, Price: {price:C2}, Related: {relatedName}"));
            }
            return View(results);
        }
        public ViewResult Index() => View("Index", new string[] { "Bob", "Joe", "Alice" });
        [HttpGet("index4")]
        public ViewResult Index4()
        {
            Dictionary<string, Product> products = new Dictionary<string, Product> 
            {
                { "Kayak", new Product { Name = "Kayak", Price = 275M } },
                { "Lifejacket", new Product{ Name = "Lifejacket", Price = 48.95M } }
            };
            return View("Index4", products.Keys);
        }
    }
}