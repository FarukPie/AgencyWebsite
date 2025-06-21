using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class WorksController : Controller
    {
        private readonly spoilerContext _context;

        public WorksController(spoilerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value=_context.Works.ToList();
            return View(value);
        }
    }
}
