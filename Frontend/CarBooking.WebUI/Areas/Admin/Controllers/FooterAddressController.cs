using CarBooking.Dtos.FooterAddressDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBooking.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/FooterAddress")]
    public class FooterAddressController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FooterAddressController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7057/api/FooterAddresses");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        [Route("CreateFooterAddress")]

        public IActionResult CreateFooterAddress()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateFooterAddress")]

        public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressDto createFooterAddress)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createFooterAddress);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7057/api/FooterAddresses", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "FooterAddress", new { area = "Admin" });

            }
            return View();
        }
        [Route("RemoveFooterAddress/{id}")]

        public async Task<IActionResult> RemoveFooterAddress(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7057/api/FooterAddresses/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "FooterAddress", new { area = "Admin" });

            }
            return View();
        }
        [HttpGet]
        [Route("UpdateFooterAddress/{id}")]

        public async Task<IActionResult> UpdateFooterAddress(int id)
        {


            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7057/api/FooterAddresses/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateFooterAddressDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        [Route("UpdateFooterAddress/{id}")]
        public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressDto updateFooterAddress)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateFooterAddress);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7057/api/FooterAddresses/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "FooterAddress", new { area = "Admin" });

            }
            return View();
        }
    }
}
