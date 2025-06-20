using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _FooterDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
