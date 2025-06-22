using AgencyWebsite.Context;
using AgencyWebsite.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

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
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _context.Abouts.Find(id);
            return View(value);

        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            _context.Abouts.Update(about);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

            

    }
}
