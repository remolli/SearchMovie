using Microsoft.AspNetCore.Mvc;
using SearchMovie.API;

namespace SearchMovie.Controllers
{
    public class SearchController : Controller
    {
        MovieAPI _movieAPI = new MovieAPI("931237d");

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Movies()
        {
            var searchResponse = await _movieAPI.GetSearchResponse("app");
            return View(searchResponse.Search);
        }

        public async Task<IActionResult> Movie(string imdbID)
        {
            var movie = await _movieAPI.GetMovie(imdbID);
            return View(movie);
        }

        public async Task<IActionResult> NextPage(int page)
        {
            var searchResponse = await _movieAPI.GetSearchResponse("app", page);
            return View("Movies", searchResponse.Search);
        }
    }
}
