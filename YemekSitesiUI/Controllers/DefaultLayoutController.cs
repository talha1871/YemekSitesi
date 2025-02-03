using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiUI.Controllers
{
    public class DefaultLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
