using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _SliderDefaultComponentPartial: ViewComponent
    {
        private readonly spoilerContext _context;

        public _SliderDefaultComponentPartial(spoilerContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value=_context.Sliders.ToList();
            return View(value);
        }

    }
}
