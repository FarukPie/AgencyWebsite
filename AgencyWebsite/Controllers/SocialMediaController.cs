using AgencyWebsite.Context;
using AgencyWebsite.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    [Authorize]
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

        [HttpGet]
        public IActionResult CreateSocial()
        {
            return View();


        }
        [HttpPost]
        public IActionResult CreateSocial(SocialMedia social)
        {
            _context.SocialMedias.Add(social);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocial(int id)
        {
            var value = _context.SocialMedias.Find(id);
            _context.SocialMedias.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSocial(int id)
        {
            var value = _context.SocialMedias.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSocial(SocialMedia social)
        {
            _context.SocialMedias.Update(social);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
