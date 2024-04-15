using Microsoft.AspNetCore.Mvc;

namespace BACKEND_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
