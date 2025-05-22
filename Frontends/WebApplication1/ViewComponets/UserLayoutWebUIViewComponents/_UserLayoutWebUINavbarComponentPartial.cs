using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponets.UserLayoutWebUIViewComponents
{
    public class _UserLayoutWebUINavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
