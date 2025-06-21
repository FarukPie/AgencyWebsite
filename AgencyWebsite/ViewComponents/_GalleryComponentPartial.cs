using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _GalleryComponentPartial:ViewComponent
    {
        private readonly spoilerContext _context;

        public _GalleryComponentPartial(spoilerContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value = _context.Galleries.ToList();
            return View(value);
        }
    }
}
