using Microsoft.AspNetCore.Mvc;

namespace CDC.PharmaSystem.Wep.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
