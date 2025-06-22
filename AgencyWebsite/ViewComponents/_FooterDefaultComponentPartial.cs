using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _FooterDefaultComponentPartial:ViewComponent
    {
        private readonly spoilerContext _context;

        public _FooterDefaultComponentPartial(spoilerContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var value=_context.SocialMedias.ToList();
            return View(value);
        }
    }
}
