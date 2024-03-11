using CarBooking.Dtos.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace CarBooking.WebUI.Views.ViewComponents.DashboardViewComponents
{
    public class _AdminDashboardChart2ComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardChart2ComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region CarCount

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7057/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.CarCount = values?.CarCount;
            }
            #endregion 
            #region BrandCount
            var responseMessage3 = await client.GetAsync("https://localhost:7057/api/Statistics/GetBrandCount");
            if (responseMessage3.IsSuccessStatusCode)
            {

                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData3);

                ViewBag.BrandCount = values3?.BrandCount;

            }
            #endregion
            return View();
        }
    }
}
