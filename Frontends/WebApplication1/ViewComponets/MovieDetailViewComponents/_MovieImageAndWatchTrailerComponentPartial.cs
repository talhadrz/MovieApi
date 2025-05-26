using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponets.MovieDetailViewComponents
{
    public class _MovieImageAndWatchTrailerComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
