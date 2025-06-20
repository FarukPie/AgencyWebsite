using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
