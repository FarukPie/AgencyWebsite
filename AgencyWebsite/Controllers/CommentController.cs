using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class CommentController : Controller
    {
        private readonly spoilerContext _context;

        public CommentController(spoilerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.Testimonials.ToList();
            return View(value);
        }
    }
}
