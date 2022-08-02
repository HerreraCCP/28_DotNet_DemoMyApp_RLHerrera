using Microsoft.AspNetCore.Mvc;

namespace RLHerrera.AppModelo.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}