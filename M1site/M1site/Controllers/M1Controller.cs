using Microsoft.AspNetCore.Mvc;

namespace M1site.Controllers
{
    public class M1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Stock()
        {
            return View();
        }
    }
}
