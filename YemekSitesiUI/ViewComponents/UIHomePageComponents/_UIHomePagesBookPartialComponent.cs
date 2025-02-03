using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiUI.ViewComponents.UIHomePageComponents
{
    public class _UIHomePagesBookPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
