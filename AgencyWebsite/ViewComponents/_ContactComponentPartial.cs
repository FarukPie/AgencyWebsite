using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        private readonly spoilerContext _context;

        public _ContactComponentPartial(spoilerContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
