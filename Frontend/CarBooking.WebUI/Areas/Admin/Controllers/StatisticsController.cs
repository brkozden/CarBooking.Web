using CarBooking.Dtos.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Statistics")]
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]

        public async Task<IActionResult> Index()
        {
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
            var responseMessage2 = await client.GetAsync("https://localhost:7057/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int LocationCountNumber = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData2);
                ViewBag.LocationCountNumber = LocationCountNumber;
                ViewBag.LocationCount = values2?.LocationCount;

            }
            var responseMessage3 = await client.GetAsync("https://localhost:7057/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int AuthorCountNumber = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData3);
                ViewBag.AuthorCountNumber = AuthorCountNumber;
                ViewBag.AuthorCount = values3?.AuthorCount;

            }
            var responseMessage4 = await client.GetAsync("https://localhost:7057/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int BlogCountNumber = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData4);
                ViewBag.BlogCountNumber = BlogCountNumber;
                ViewBag.BlogCount = values4?.BlogCount;

            }
            var responseMessage5 = await client.GetAsync("https://localhost:7057/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int BrandCountNumber = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData5);
                ViewBag.BrandCountNumber = BrandCountNumber;
                ViewBag.BrandCount = values5?.BrandCount;

            }
            var responseMessage6 = await client.GetAsync("https://localhost:7057/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int AvgPriceForDailyNumber = random.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData6);
                ViewBag.AvgPriceForDailyNumber = AvgPriceForDailyNumber;
                ViewBag.GetAvgRentPriceForDaily = values6?.AvgPriceForDaily.ToString("0.00");

            }
            var responseMessage7 = await client.GetAsync("https://localhost:7057/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int AvgRentPriceForWeeklyNumber = random.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData7);
                ViewBag.AvgRentPriceForWeeklyNumber = AvgRentPriceForWeeklyNumber;
                ViewBag.AvgRentPriceForWeekly = values7?.AvgPriceForWeekly.ToString("0.00");

            }
            var responseMessage8 = await client.GetAsync("https://localhost:7057/api/Statistics/GetAvgRentPriceForMonthly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int AvgRentPriceForMonthlyNumber = random.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData8);
                ViewBag.AvgRentPriceForMonthlyNumber = AvgRentPriceForMonthlyNumber;
                ViewBag.AvgRentPriceForMonthly = values8?.AvgPriceForMonthly.ToString("0.00");

            }
            var responseMessage9 = await client.GetAsync("https://localhost:7057/api/Statistics/GetCarCountByTransmissionIsAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int number9 = random.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData9);
                ViewBag.number9 = number9;
                ViewBag.GetCarCountByTransmissionIsAuto = values9?.CarCountByTransmissionIsAuto;

            }
            var responseMessage10 = await client.GetAsync("https://localhost:7057/api/Statistics/GetBrandNameByMostCar");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int BrandNameByMostCarNumber = random.Next(0, 101);
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData10);
                ViewBag.BrandNameByMostCarNumber = BrandNameByMostCarNumber;
                ViewBag.BrandNameByMostCar = values10?.BrandNameByMostCar;

            }
            var responseMessage11 = await client.GetAsync("https://localhost:7057/api/Statistics/GetCarCountByKmLessThan30000");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int CarCountByKmLessThan30000Number = random.Next(0, 101);
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData11);
                ViewBag.CarCountByKmLessThan30000Number = CarCountByKmLessThan30000Number;
                ViewBag.CarCountByKmLessThan30000 = values11?.CarCountByKmLessThan30000;

            }
            var responseMessage12 = await client.GetAsync("https://localhost:7057/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int CarCountByFuelGasolineOrDieselNumber = random.Next(0, 101);
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData12);
                ViewBag.CarCountByFuelGasolineOrDieselNumber = CarCountByFuelGasolineOrDieselNumber;
                ViewBag.CarCountByFuelGasolineOrDiesel = values12?.CarCountByFuelGasolineOrDiesel;

            }
            var responseMessage13 = await client.GetAsync("https://localhost:7057/api/Statistics/GetCarCountByFuelElectric");
            if (responseMessage13.IsSuccessStatusCode)
            {
                int CarCountByFuelElectricNumber = random.Next(0, 101);
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData13);
                ViewBag.CarCountByFuelElectricNumber = CarCountByFuelElectricNumber;
                ViewBag.CarCountByFuelElectric = values13?.CarCountByFuelElectric;

            }
            var responseMessage14 = await client.GetAsync("https://localhost:7057/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage14.IsSuccessStatusCode)
            {
                int CarBrandAndModelByRentPriceDailyMinNumber = random.Next(0, 101);
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData14);
                ViewBag.CarBrandAndModelByRentPriceDailyMinNumber = CarBrandAndModelByRentPriceDailyMinNumber;
                ViewBag.CarBrandAndModelByRentPriceDailyMin = values14?.CarBrandAndModelByRentPriceDailyMin;

            }
            //var responseMessage15 = await client.GetAsync("https://localhost:7057/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            //if (responseMessage15.IsSuccessStatusCode)
            //{
            //    int number15 = random.Next(0, 101);
            //    var jsonData15 = responseMessage15.Content.ReadAsStringAsync().ToString();
            //    var values15 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData15);
            //    ViewBag.number15 = number15;
            //    ViewBag.carBrandAndModelByRentPriceDailyMax = values15?.carBrandAndModelByRentPriceDailyMax;
            //}

            //var responsemessage16 = await client.GetAsync("https://localhost:7057/api/statistics/getblogtitlebymostblogcomment");
            //if (responsemessage16.IsSuccessStatusCode)
            //{
            //    int number16 = random.Next(0, 101);
            //    var jsondata16 = responsemessage16.Content.ReadAsStringAsync().ToString();
            //    var values16 =  JsonConvert.DeserializeObject<ResultStatisticDto>(jsondata16);
            //    ViewBag.number16 = number16;
            //    ViewBag.blogtitlebymostblogcomment = values16?.BlogTitleByMostBlogComment;

            //}
            return View();
        }


    }
}
