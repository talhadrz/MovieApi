using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponets.UserLayoutWebUIViewComponents
{
    public class _UserLayoutWebUIFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
