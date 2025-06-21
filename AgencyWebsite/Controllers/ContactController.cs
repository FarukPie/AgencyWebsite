using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class ContactController : Controller
    {
        private readonly spoilerContext _context;

        public ContactController(spoilerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value=_context.Contacts.ToList();
            return View(value);
        }
    }
}
