using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _AdminTopBarComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
    
}
