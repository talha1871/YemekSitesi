using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiUI.ViewComponents
{
    public class _LayoutHeaderPartialComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
