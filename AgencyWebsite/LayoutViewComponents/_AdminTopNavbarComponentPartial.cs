using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.LayoutViewComponents
{
    public class _AdminTopNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
