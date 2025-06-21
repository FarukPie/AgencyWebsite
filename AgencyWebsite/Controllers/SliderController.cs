using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class SliderController : Controller
    {
        private readonly spoilerContext _context;

        public SliderController(spoilerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value=_context.Sliders.ToList();
            return View(value);
        }
    }
}
