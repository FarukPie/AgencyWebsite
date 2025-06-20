using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
