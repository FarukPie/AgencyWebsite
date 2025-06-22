using AgencyWebsite.Context;
using AgencyWebsite.Entities;
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


        [HttpGet]
        public IActionResult CreateGallery()
        {
            return View();


        }
        [HttpPost]
        public IActionResult CreateGallery(Gallery gallery)
        {
            _context.Galleries.Add(gallery);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteGallery(int id)
        {
            var value = _context.Galleries.Find(id);
            _context.Galleries.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateGallery(int id)
        {
            var value = _context.Galleries.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateGallery(Gallery gallery)
        {
            _context.Galleries.Update(gallery);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
