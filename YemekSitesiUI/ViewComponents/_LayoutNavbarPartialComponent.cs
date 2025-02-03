using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiUI.ViewComponents
{
    public class _LayoutNavbarPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
