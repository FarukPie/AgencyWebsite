using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class AboutController : Controller
    {
        private readonly spoilerContext _context;

        public AboutController(spoilerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.Abouts.ToList();
            return View(value);
        }
    }
}
