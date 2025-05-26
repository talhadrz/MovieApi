using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponets.MovieDetailViewComponents
{
    public class _MovieDetailRateComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
