using Microsoft.AspNetCore.Mvc;
using SearchMovie.API;

namespace SearchMovie.Controllers
{
    public class SearchController : Controller
    {
        MovieAPI _movieAPI = new MovieAPI("931237d");
        
        public async Task<IActionResult> Index(string search)
        {
            if (search == null)
            {
                search = "Spider";
            }
            else if (search.Length < 3)
            {
                return View("TooMuchResults", search);
            }

            var searchResponse = await _movieAPI.GetSearchResponse(search);

            if (searchResponse.Search == null)
            {
                return View("NotFound");
            }
            return View(searchResponse.Search);
        }

        public async Task<IActionResult> Movie(string id)
        {
            var movie = await _movieAPI.GetMovie(id);
            return View(movie);
        }
    }
}
