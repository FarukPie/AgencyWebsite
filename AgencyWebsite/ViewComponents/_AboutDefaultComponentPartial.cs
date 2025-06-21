using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _AboutDefaultComponentPartial: ViewComponent
    {
        private readonly spoilerContext _context;
        public _AboutDefaultComponentPartial(spoilerContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value=_context.Abouts.ToList();
            return View(value);
        }

    }
}
