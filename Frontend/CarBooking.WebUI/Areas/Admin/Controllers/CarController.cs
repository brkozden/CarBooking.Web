using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Car")]
    public class CarController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
