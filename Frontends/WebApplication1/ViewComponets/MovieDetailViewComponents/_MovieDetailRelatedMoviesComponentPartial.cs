using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponets.MovieDetailViewComponents
{
    public class _MovieDetailRelatedMoviesComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
