using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorldNews.Data;
using WorldNews.Models;

namespace WorldNews.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext Context;
        public HomeController(ILogger<HomeController> logger , ApplicationDbContext _Context)
        {
            _logger = logger;

            this.Context = _Context;

        }

        public IActionResult AllNews(int id)
        {
            if (id == 4)
            {
                return RedirectToAction("MiddleEast");
            }
            else if(id == 8)
            {
                return RedirectToAction("scienceAndTechnology");
            }
            else if (id == 11)
            {
                return RedirectToAction("scienceAndTechnology");
            }
            else if (id == 12)
            {
                return RedirectToAction("scienceAndTechnology");
            }
            else if (id == 13)
            {
                return RedirectToAction("scienceAndTechnology");
            }
            else if (id == 15)
            {
                return RedirectToAction("scienceAndTechnology");
            }

            return View();

        }



     [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Categories()
        {

            var allCategories = Context.Categories.ToList();
            return View(allCategories);
        }

        public IActionResult MiddleEast()
        {
            var data = Context.News.Where(d => d.CategoryId == 4).ToList();
            return View(data);
        }



        public IActionResult ScienceAndTechnology()
        {
            var data = Context.News.Where(d => d.CategoryId == 8).ToList();
            return View(data);
        }


        [HttpGet]
       public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactUs contact )
        {
          if (ModelState.IsValid)
            {
                Context.Contacts.Add(contact);
                Context.SaveChanges();
                return RedirectToAction("Categories", "Home");

            }

            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
