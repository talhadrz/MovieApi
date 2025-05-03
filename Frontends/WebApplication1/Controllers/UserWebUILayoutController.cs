using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserWebUILayoutController : Controller
    {
        public IActionResult LayoutUI()
        {
            return View();
        }
    }
}
