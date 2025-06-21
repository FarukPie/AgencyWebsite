using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _TotalCountDefaultComponentPartial:ViewComponent
    {
        private readonly spoilerContext _context;

        public _TotalCountDefaultComponentPartial(spoilerContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value=_context.Works.ToList();
            return View(value);
        }
   
    }
}
