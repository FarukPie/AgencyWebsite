using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _Top2PhotosComponentPartial:ViewComponent
    {
        private readonly spoilerContext _context;

        public _Top2PhotosComponentPartial(spoilerContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value=_context.TwoPhotos.ToList();
            return View(value);
        }
 
    }
}
