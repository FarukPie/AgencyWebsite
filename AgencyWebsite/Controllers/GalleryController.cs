using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class GalleryController : Controller
    {
        private readonly spoilerContext _context;

        public GalleryController(spoilerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value=_context.Galleries.ToList();
            return View(value);
        }
    }
}
