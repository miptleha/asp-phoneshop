using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhoneShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ShopContext _db;

        public HomeController(ILogger<HomeController> logger, ShopContext db)
        {
            _logger = logger;
            _db = db;
            
        }

        public IActionResult Index()
        {
            return View(_db.Phones);
        }

        public IActionResult Buy(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");

            var p = _db.Phones.Find(id);
            if (p == null)
                return RedirectToAction("Index");

            return View(p);
        }

        [HttpPost]
        public IActionResult Buy(Order o)
        {
            _db.Orders.Add(o);
            _db.SaveChanges();
            return RedirectToAction("Thanks", o);
        }

        public IActionResult Thanks(Order o)
        {
            o.Phone = _db.Phones.Find(o.PhoneId);
            return View(o);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
