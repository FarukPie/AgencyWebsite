using AgencyWebsite.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    [Authorize]
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
        public IActionResult DeleteContact(int id)
        {
            var value = _context.Contacts.Find(id);
            _context.Contacts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
