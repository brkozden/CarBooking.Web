using CarBooking.Dtos.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.Views.ViewComponents.DashboardViewComponents
{
    public class _AdminStatisticsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region CarCount
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7057/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int CarCountNumber = random.Next(0, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.CarCountNumber = CarCountNumber;
                ViewBag.CarCount = values?.CarCount;
            }
            #endregion
            #region LocationCount
            var responseMessage2 = await client.GetAsync("https://localhost:7057/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int LocationCountNumber = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData2);
                ViewBag.LocationCountNumber = LocationCountNumber;
                ViewBag.LocationCount = values2?.LocationCount;

            }
            #endregion
            #region BrandCount
            var responseMessage3 = await client.GetAsync("https://localhost:7057/api/Statistics/GetBrandCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int BrandCountNumber = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData3);
                ViewBag.BrandCountNumber = BrandCountNumber;
                ViewBag.BrandCount = values3?.BrandCount;

            }
            #endregion
            #region AvgRentPriceForDaily
            var responseMessage4 = await client.GetAsync("https://localhost:7057/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int AvgPriceForDailyNumber = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData4);
                ViewBag.AvgPriceForDailyNumber = AvgPriceForDailyNumber;
                ViewBag.AvgRentPriceForDaily= values4?.AvgPriceForDaily.ToString("0.00");

            }
            #endregion
            return View();
        }
    }
}
