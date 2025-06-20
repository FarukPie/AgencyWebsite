using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _AdminFooterComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
