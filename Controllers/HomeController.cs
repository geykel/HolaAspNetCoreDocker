using Microsoft.AspNetCore.Mvc;

namespace HolaAspNetCoreDocker
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}