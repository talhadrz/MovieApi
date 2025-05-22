using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponets.UserLayoutWebUIViewComponents
{
    public class _UserLayoutWebUIHeroComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
