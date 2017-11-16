using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();

        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route ("/Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            // Add the new cheese to my existing cheeses
            Cheeses.Add(name, description);

            return Redirect("/Cheese");
        }

        [HttpPost]
        [Route("/Cheese/Remove")]
        public IActionResult RemoveCheese(string removedCheese)
        {
            if (String.IsNullOrEmpty(removedCheese))
            {
                ViewBag.error = "Please select a cheese";
                ViewBag.cheeses = Cheeses;
                return View("Remove");
            }
            Cheeses.Remove(removedCheese);
            return Redirect("/Cheese");
        }

        [HttpGet]
        public IActionResult RemoveWithCheckBoxes()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }

        [HttpPost]
        [Route("/Cheese/RemoveWithCheckboxes")]
        public IActionResult RemoveWithCheckboxes(string[] cheesesToRemove)
        {
            foreach (var cheese in cheesesToRemove)
            {
                Cheeses.Remove(cheese);
            }

            return Redirect("/Cheese");
        }
    }
}
