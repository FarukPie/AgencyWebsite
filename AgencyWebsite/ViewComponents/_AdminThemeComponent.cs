using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _AdminThemeComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
