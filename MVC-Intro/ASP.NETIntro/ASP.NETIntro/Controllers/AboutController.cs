using Microsoft.AspNetCore.Mvc;

namespace ASP.NETIntro.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public JsonResult AboutJson()
        {
            return Json(new { id = 1, Name = "ASP.NET MVC About",  language = "C#" });
        }

        public ContentResult AboutContent()
        {
            return Content("  Lorem ipsum dolor sit amet consectetur adipisicing elit.\n " +
                " A asperiores possimus dolore aliquid? Quos aperiam quod libero minus veniam non temporibus est, " +
                "autem neque?\r\n  Corporis odit facilis sed vel aut.Lorem ipsum dolor, sit amet consectetur adipisicing elit. \r\n" +
                " Aliquam, porro. Lorem ipsum dolor sit, amet consectetur adipisicing elit.\n  " +
                "Reiciendis, minima molestias rerum repellat aliquid minus nihil autem tempora ea optio.\n " +
                "A asperiores possimus dolore aliquid? Quos aperiam quod libero minus veniam non temporibus est, autem neque?");
        }
    }
}
