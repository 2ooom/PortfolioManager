using Microsoft.AspNetCore.Mvc;

namespace PortfolioManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
