using CarBooking.Dtos.BlogDtos;
using CarBooking.Dtos.CommentDtos;
using CarBooking.Dtos.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBooking.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.title1 = "Bloglar";
            ViewBag.title2 = "Yazarlarımızın Blogları";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7057/api/Blogs/GetAllBlogsWithAuthorsList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.title1 = "Bloglar";
            ViewBag.title2 = "Blog Detayları";
            ViewBag.blogId = id;
            return View();
        }
        [HttpGet]
        public PartialViewResult CreateComment(int id)
        {
            ViewBag.blogId = id;

            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentDto createCommentDto)
        {
           

            var client = _httpClientFactory.CreateClient();
            createCommentDto.CreatedDate = DateTime.Now;
            var jsonData = JsonConvert.SerializeObject(createCommentDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7057/api/Comments", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("BlogDetail", new RouteValueDictionary(
     new { controller = "Blog", action = "BlogDetail", Id = createCommentDto.BlogId }));
            }
            return View();

        }
    }
}
