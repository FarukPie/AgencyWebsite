using AgencyWebsite.Context;
using AgencyWebsite.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgencyWebsite.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {

        
        private readonly spoilerContext _context;

        public DefaultController(spoilerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

      
    }
}
