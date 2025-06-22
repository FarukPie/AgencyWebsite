using AgencyWebsite.Context;
using AgencyWebsite.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    public class SliderController : Controller
    {
        private readonly spoilerContext _context;

        public SliderController(spoilerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.Sliders.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();


        }
        [HttpPost]
        public IActionResult CreateSlider(Slider slider)
        {
            _context.Sliders.Add(slider);
            _context.SaveChanges();
            return RedirectToAction ("Index");
        }

        public IActionResult DeleteSlider(int id)
        {
            var value = _context.Sliders.Find(id);
            _context.Sliders.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var value=_context.Sliders.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSlider(Slider slider)
        {
            _context.Sliders.Update(slider);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
