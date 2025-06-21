using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
