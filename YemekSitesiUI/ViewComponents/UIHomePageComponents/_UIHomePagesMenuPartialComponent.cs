using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YemekSitesiUI.Dtos.ProductDtos;
using YemekSitesiUI.Dtos.SliderDtos;

namespace YemekSitesiUI.ViewComponents.UIHomePageComponents
{
    public class _UIHomePagesMenuPartialComponent:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _UIHomePagesMenuPartialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7254/api/Product");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
            return View(values);
        }
    }
}
