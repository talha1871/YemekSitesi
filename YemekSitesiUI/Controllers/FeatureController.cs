using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;
using YemekSitesiUI.Dtos.FeatureDtos;

namespace YemekSitesiUI.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FeatureController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMes = await client.GetAsync("https://localhost:7254/api/Feature");
            if (responseMes.IsSuccessStatusCode)
            {
                var json = await responseMes.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(json);
                return View(values);
            }
            return View();

        }
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createFeatureDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7254/api/Feature", content);
            if (response.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteFeature(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:7254/api/Feature/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]

        public async Task<IActionResult> UpdateFeature(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMess = await client.GetAsync($"https://localhost:7254/api/Feature/{id}");
            if (responseMess.IsSuccessStatusCode)
            { 
                var jsonDta = await responseMess.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateFeatureDto>(jsonDta);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateFeatureDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMes = await client.PutAsync("https://localhost:7254/api/Feature/", stringContent);
            if (responseMes.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index");
            }
            return View();
        }



       

    }
}
