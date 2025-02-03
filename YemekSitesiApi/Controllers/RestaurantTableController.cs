using BL_YemekSitesi.Managers.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantTableController : ControllerBase
    {
        private readonly IRestaurantTableManager _restaurantTableManager;

        public RestaurantTableController(IRestaurantTableManager restaurantTableManager)
        {
            _restaurantTableManager = restaurantTableManager;
        }

        [HttpGet("RestaurantTableCount")]
        public IActionResult GetRestaurantTableCount()
        { 
            return Ok(_restaurantTableManager.TRestaurantTableCount());
        }
    }
}
