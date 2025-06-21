using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class PhotoController : Controller
    {
        private readonly spoilerContext _context;

        public PhotoController(spoilerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value=_context.TwoPhotos.ToList();
            return View(value);
        }
    }
}
