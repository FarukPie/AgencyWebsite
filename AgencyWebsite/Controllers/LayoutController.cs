using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
