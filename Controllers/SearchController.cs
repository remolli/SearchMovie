using Microsoft.AspNetCore.Mvc;

namespace SearchMovie.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
