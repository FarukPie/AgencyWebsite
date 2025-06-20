using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _Top2PhotosComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
 
    }
}
