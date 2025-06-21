using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.LayoutViewComponents
{
    public class _AdminHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
