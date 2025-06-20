using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _GalleryComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
