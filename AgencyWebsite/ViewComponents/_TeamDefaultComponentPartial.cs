using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _TeamDefaultComponentPartial:ViewComponent
    {
        private readonly spoilerContext _context;

        public _TeamDefaultComponentPartial(spoilerContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value = _context.Teams.ToList();
            return View(value);
        }
    }
}
