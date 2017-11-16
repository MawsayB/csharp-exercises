using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        
        public IActionResult Index()
        {
            string text = "<form action='/Hello/CreateMessage' method='post')>" +
                "<label>Enter Your Name: <input type='text' name='firstname' /></label>" +
                "<select name='language'>" +
                "<option value='French'>French</option> " +
                "<option value ='Spanish'>Spanish</option>" +
                "<option value = 'Minion'>Minion</option>" +
                "<option value = 'Dutch'>Dutch</option>" +
                "<option value = 'Port'>Portuguese</option>" +
                "</select>" +
                "<input type='submit' value='Greet me!'/>" +
                "</form>";

            return Content(text, "text/HTML");
        }

        [HttpPost]
        public IActionResult CreateMessage(string firstname, string language)
        {
            string greeting = "";
        
            switch (language)
            {
                case "French":
                {
                    greeting = "Bonjour";
                    break;
                }
                case "Spanish":
                {
                    greeting = "Hola";
                    break;
                }

                case "Minion":
                {
                    greeting = "Bello";
                    break;
                }

                case "Dutch":
                {
                    greeting = "Hallo";
                    break;
                }

                case "Port":
                {
                    greeting = "Ola";
                    break;
                }
                default:
                {
                    throw new Exception("Hey this language isn't supported");
                }
            }

            return Content(string.Format("{0}, {1}!", greeting, firstname, "text/HTML"));
            
            }
        }
    }
