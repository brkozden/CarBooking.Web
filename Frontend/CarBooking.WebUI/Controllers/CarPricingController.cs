using CarBooking.Dtos.BlogDtos;
using CarBooking.Dtos.CarPricingDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBooking.WebUI.Controllers
{
    public class CarPricingController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public CarPricingController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			ViewBag.title1 = "Fiyatlar";
            ViewBag.title2 = "Araba Fiyat Listesi"; var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7057/api/CarPricings/GetCarPricingWithTimePeriodList");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCarPricingListWithTimePeriodDto>>(jsonData);
				return View(values);
			}
			return View();
        }
    }
}
