using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using YemekSitesiUI.Dtos;

namespace YemekSitesiUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult>Index()
        {
            
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7254/api/Category");
            if(response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(json);
                return View(values);
            }
            return View();
        }
        [HttpGet]        
        
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            createCategoryDto.Status = true;
            var client = _httpClientFactory.CreateClient();
            var jsonDataSerialize = JsonConvert.SerializeObject(createCategoryDto);
            StringContent stringContent = new StringContent(jsonDataSerialize, Encoding.UTF8, "application/json");
            var responseMess = await client.PostAsync("https://localhost:7254/api/Category", stringContent);
            if (responseMess.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7254/api/Category/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCategoryDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateCategoryDto);
            HttpContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7254/api/Category", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7254/api/Category/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
