using Microsoft.AspNetCore.Mvc;

namespace AgencyWebsite.ViewComponents
{
    public class _NavbarDefaultComponentPartial : ViewComponent
    {
      public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
