using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YemekSitesiUI.Dtos.AboutDtos;

namespace YemekSitesiUI.ViewComponents.UIHomePageComponents
{
    public class _UIHomePagesAboutPartialComponent: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _UIHomePagesAboutPartialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMess = await client.GetAsync("https://localhost:7254/api/About");
            var jsonData = await responseMess.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
            return View(values);
            
        }
    }
}
