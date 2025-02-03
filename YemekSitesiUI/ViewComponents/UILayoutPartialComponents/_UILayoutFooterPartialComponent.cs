using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YemekSitesiUI.Dtos.ContactDtos;

namespace YemekSitesiUI.ViewComponents.UILayoutPartialComponents
{
    public class _UILayoutFooterPartialComponent: ViewComponent
    {
        public readonly IHttpClientFactory _httpClientFactory;

        public _UILayoutFooterPartialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7254/api/Contact");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
            return View(values);
        }
    }
}
