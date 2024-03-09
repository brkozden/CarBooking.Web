using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title1 = "Hakkımızda";
            ViewBag.title2 = "Vizyonumuz & Misyonumuz";


            return View();
        }
    }
}
