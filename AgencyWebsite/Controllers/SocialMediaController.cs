using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly spoilerContext _context;

        public SocialMediaController(spoilerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value=_context.SocialMedias.ToList();
            return View(value);
        }
    }
}
