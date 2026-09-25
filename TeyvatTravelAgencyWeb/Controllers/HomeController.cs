using Microsoft.AspNetCore.Mvc;

namespace TeyvatTravelAgencyWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: /  and  /Home/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
