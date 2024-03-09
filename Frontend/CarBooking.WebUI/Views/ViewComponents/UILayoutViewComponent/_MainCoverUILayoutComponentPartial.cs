using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.Views.ViewComponents.UILayoutViewComponent
{
    public class _MainCoverUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
