using CarBooking.Dtos.CarDescriptionDtos;
using CarBooking.Dtos.CarFeatureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.Views.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailDescriptionComponentPartial:ViewComponent
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public _CarDetailDescriptionComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			ViewBag.carId = id;
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7057/api/CarDescriptions/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultCarDescriptionDto>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
