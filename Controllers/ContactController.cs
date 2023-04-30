using Microsoft.AspNetCore.Mvc;

namespace SearchMovie.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
