using Microsoft.AspNetCore.Mvc;

namespace TeyvatTravelAgency.Controllers
{
    public class HomeController : Controller
    {
        // GET: /  and  /Home/Index
        // The main marketing landing page.
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/Profile
        // Company profile & About the Director.
        public IActionResult Profile()
        {
            return View();
        }
    }
}
