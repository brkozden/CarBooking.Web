using CarBooking.Dtos.BlogDtos;
using CarBooking.Dtos.CommentDtos;
using CarBooking.Dtos.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBooking.WebUI.Views.ViewComponents.BlogViewComponents
{
    public class _BlogDetailMainComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailMainComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7057/api/Blogs/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultBlogByIdDto>(jsonData);
                var getCountComments = await client.GetAsync("https://localhost:7057/api/Comments/GetCountCommentByBlog?id=" + id);
                if (getCountComments.IsSuccessStatusCode)
                {
                    var jsonData2 = await getCountComments.Content.ReadAsStringAsync();
                    var count = JsonConvert.DeserializeObject(jsonData2);
                    if (count != null)
                    {
                        ViewBag.CommentCount = count;
                    }
                    else
                    {
                        ViewBag.CommentCount = 0;

                    }
                }
                return View(values);
            }
          
          
            return View();
        }
    }
}
