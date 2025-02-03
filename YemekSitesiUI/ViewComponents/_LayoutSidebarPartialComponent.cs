using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiUI.ViewComponents
{
    public class _LayoutSidebarPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
