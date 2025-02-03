using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
