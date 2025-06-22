using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class HomePageController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
