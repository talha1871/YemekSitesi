using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiUI.ViewComponents
{
    public class _LayoutScriptPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
