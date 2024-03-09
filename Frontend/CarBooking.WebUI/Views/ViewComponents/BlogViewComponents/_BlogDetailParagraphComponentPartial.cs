using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.Views.ViewComponents.BlogViewComponents
{
    public class _BlogDetailParagraphComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
