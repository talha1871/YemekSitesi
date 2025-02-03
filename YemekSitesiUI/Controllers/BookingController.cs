using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using YemekSitesiUI.Dtos.BookingDtos;

namespace YemekSitesiUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = await client.GetAsync("https://localhost:7254/api/Booking");
            if (jsondata.IsSuccessStatusCode)
            { 
                var json = await jsondata.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(json);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult CreateBooking()
        {
            return View();
        }
       

        [HttpPost]
        public async Task<IActionResult> CreateBooking(CreateBookingDto createBookingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonDataa = JsonConvert.SerializeObject(createBookingDto);
            StringContent stringContent = new StringContent(jsonDataa, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7254/api/Booking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> UpdateBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonD = await client.GetAsync($"https://localhost:7254/api/Booking/{id}");
            if (jsonD.IsSuccessStatusCode) 
            {
                var responseMess = await jsonD.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateBookingDto>(responseMess);
                return View(values);
            }
            return View();

        }

        [HttpPost]
        
        public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7254/api/Booking/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var json = await client.DeleteAsync($"https://localhost:7254/api/Booking/{id}");
            if (json.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
