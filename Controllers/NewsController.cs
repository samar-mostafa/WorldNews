using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorldNews.Data;

namespace WorldNews.Controllers
{
   
    
    public class NewsController : Controller
    {
        private readonly ApplicationDbContext Context;
        public NewsController(ApplicationDbContext _Context)
        {
            this.Context = _Context;
        }
        public IActionResult MiddleEast(int id)
        {
            var n = Context.News.Find(id);
            return View(n);
        }
    }
}
