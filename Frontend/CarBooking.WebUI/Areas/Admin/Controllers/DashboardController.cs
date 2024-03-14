using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Dashboard")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
