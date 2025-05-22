using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponets.UserLayoutWebUIViewComponents
{
    public class _UserLayoutWebUILoginModalComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
