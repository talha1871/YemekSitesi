using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YemekSitesiUI.Dtos.TestimonialDtos;

namespace YemekSitesiUI.ViewComponents.UIHomePageComponents
{
    public class _UIHomePagesClientPartialComponent:ViewComponent
    {
        private  readonly IHttpClientFactory _httpClientFactory;

        public _UIHomePagesClientPartialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7254/api/Testimonial");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
            return View(value);
        }
    }
}
