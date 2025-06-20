using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _TotalCountDefaultComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
   
    }
}
