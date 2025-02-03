using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiUI.ViewComponents.UILayoutPartialComponents
{
    public class _UILayoutScriptPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    } 
}
