using AgencyWebsite.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _NavbarDefaultComponentPartial : ViewComponent
    {
        private readonly spoilerContext _context;
public _NavbarDefaultComponentPartial(spoilerContext context)
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
