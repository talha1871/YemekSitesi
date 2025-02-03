using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiUI.ViewComponents
{
    public class _LayoutFooterPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
