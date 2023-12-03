using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace ASP.NETIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string IndexWelcome()
        {
            return "Hello ASP.NET MVC";
        }

        public RedirectResult IndexDirect()
        {
            return Redirect("https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-7.0&tabs=visual-studio");
        }
    }
}
