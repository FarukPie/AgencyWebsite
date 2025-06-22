using AgencyWebsite.Context;
using AgencyWebsite.Entities;
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

        [HttpGet]
        public IActionResult UpdatePhoto(int id)
        {
            var value = _context.TwoPhotos.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePhoto(TwoPhoto photo)
        {
            _context.TwoPhotos.Update(photo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
