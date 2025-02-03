using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YemekSitesiUI.Dtos.DiscountDtos;
using YemekSitesiUI.Dtos.SliderDtos;

namespace YemekSitesiUI.ViewComponents.UIHomePageComponents
{
    public class _UIHomePagesOfferPartialComponent: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _UIHomePagesOfferPartialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7254/api/Discount");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultDiscountDto>>(jsonData);
            return View(values);
        }
    }
}
