using AgencyWebsite.Context;
using AgencyWebsite.Entities;
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

        [HttpGet]
        public IActionResult CreateWork()
        {
            return View();


        }
        [HttpPost]
        public IActionResult CreateWork(Work work)
        {
            _context.Works.Add(work);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteWork(int id)
        {
            var value = _context.Works.Find(id);
            _context.Works.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateWork(int id)
        {
            var value = _context.Works.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateWork(Work work)
        {
            _context.Works.Update(work);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
