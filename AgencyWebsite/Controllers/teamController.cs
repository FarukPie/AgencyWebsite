using AgencyWebsite.Context;
using AgencyWebsite.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.Controllers
{
    [Authorize]
    public class teamController : Controller
    {
        private readonly spoilerContext _context;
        public teamController(spoilerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.Teams.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateTeam()
        {
            return View();


        }
        [HttpPost]
        public IActionResult CreateTeam(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTeam(int id)
        {
            var value = _context.Teams.Find(id);
            _context.Teams.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {
            var value = _context.Teams.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTeam(Team team)
        {
            _context.Teams.Update(team);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
