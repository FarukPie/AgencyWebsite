using AgencyWebsite.Context;
using AgencyWebsite.Entities;
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

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Submit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();

                TempData["Success"] = "Mesajınız başarıyla iletildi!";
                return RedirectToAction("Index", "Default");
            }
            else
            {
                TempData["Error"] = "Lütfen tüm alanları eksiksiz doldurun!";
                return RedirectToAction("Index", "Default");
            }

        }




    }
}
