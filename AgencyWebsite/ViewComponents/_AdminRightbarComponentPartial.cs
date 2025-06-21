using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _AdminRightbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
