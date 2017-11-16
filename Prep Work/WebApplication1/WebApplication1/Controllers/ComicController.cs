using Microsoft.AspNetCore.Mvc;

namespace Comics.Controllers
{
    public class ComicsController : Controller
    {
        // http://localhost:999/Comics?name=spider-man&price=99
        public IActionResult Index(string name, int price)
        {
            var text = string.Format("<h1>comics</h1>name:{0}<br/>price:{1}", name, price);
            return Content(text, "text/html");
        }

        // http://localhost:999/Comics/Add
        public IActionResult Add()

        {
            var text = "<form action='/comics/saved' method='post'>" +
                "<label>name<input name='name' type='text'></label>" +
                "<input type='submit' value='submit'/>" +
                "</form>";
            return Content(text, "text/html");
        }

        [HttpPost]
        public IActionResult Saved(string name)

        {
            var text = string.Format("saved {0}", name);
            return Content(text, "text/html");
        }

        [Route("/Comics/viewStuff/{text}")]
        public IActionResult ViewStuff(string text)

        {
            var moreText = "here is the text: " + text;
            return Content(moreText, "text/html");
        }

    }

}