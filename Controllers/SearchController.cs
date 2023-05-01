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

        public async Task<IActionResult> Movies(string search)
        {
            var searchResponse = await _movieAPI.GetSearchResponse(search);
            return View(searchResponse.Search);
        }
    }
}
