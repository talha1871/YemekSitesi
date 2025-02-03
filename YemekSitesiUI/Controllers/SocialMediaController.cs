using YemekSitesiUI.Dtos.SocialMediaDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace YemekSitesiUI.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SocialMediaController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMess = await client.GetAsync("https://localhost:7254/api/SocialMedia");
            if (responseMess.IsSuccessStatusCode)
            {
                var jsonData = await responseMess.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]

        public IActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            var client = _httpClientFactory.CreateClient();
            var json = JsonConvert.SerializeObject(createSocialMediaDto);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseMess = await client.PostAsync("https://localhost:7254/api/SocialMedia", content);
            if (responseMess.IsSuccessStatusCode) 
            { 
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteSocialMedia(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7254/api/SocialMedia/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        
        public async Task<IActionResult> UpdateSocialMedia(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7254/api/SocialMedia/{id}");
            if (response.IsSuccessStatusCode)
            { 
                var jsonDta = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateSocialMediaDto>(jsonDta);
                return View(values);
            }
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonDta = JsonConvert.SerializeObject(updateSocialMediaDto);
            StringContent content = new StringContent(jsonDta, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:7254/api/SocialMedia/", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }

        
            
    }
}
