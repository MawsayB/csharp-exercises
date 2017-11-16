using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComicsCSharp.Controllers
{
    public class ComicsController : Controller
    {
        private static List<string> comics = new List<string>();
        
        public IActionResult Index()
        {
            //comics.Add("Spider-man - Issue 1");
            //comics.Add("Spider-man - Issue 2");
            //comics.Add("Spider-man - Issue 3");

            ViewBag.comics = comics;
            return View();
        }

        [HttpPost]
        public IActionResult Add(string comic)
        {
            comics.Add(comic);
            return Redirect("/Comics");
        }

    }
}