using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponets.MovieDetailViewComponents
{
    public class _MovieDetailOverviewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
