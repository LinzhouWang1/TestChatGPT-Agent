using Microsoft.AspNetCore.Mvc;

namespace TestAgent.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
