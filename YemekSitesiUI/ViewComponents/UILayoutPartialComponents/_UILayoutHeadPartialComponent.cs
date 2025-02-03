using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiUI.ViewComponents.UILayoutPartialComponents
{
    public class _UILayoutHeadPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
