using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
