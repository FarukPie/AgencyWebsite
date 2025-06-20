using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _AdminHeadComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
