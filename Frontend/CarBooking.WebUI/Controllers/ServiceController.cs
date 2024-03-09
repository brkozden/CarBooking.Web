
using CarBooking.Dtos.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.Controllers
{
    public class ServiceController : Controller
    {
      

        public IActionResult Index()
        {
            ViewBag.title1 = "Hizmetler";
            ViewBag.title2 = "Hizmetlerimiz";


            return View();
        }
    }
}
