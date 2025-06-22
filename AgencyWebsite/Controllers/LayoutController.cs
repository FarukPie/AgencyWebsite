using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    [Authorize]
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
