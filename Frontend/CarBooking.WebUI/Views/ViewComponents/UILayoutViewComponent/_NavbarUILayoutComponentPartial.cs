using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.Views.ViewComponents.UILayoutViewComponent
{
    public class _NavbarUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
