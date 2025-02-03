using BL_YemekSitesi.Managers.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderManager _orderManager;

        public OrderController(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        [HttpGet("TotalOrderCount")]
        public IActionResult GetTotalOrderCount()
        { 
            return Ok(_orderManager.TTotalOrderCount());
        }

        [HttpGet("ActiveOrderCount")]
        public IActionResult GetActiveOrderCount()
        {
            return Ok(_orderManager.TActiveOrderCount());
        }
        [HttpGet("LastTotalOrderFee")]

        public IActionResult GetLastTotalOrderFee()
        {
            return Ok(_orderManager.TLastTotalOrderFee());
        }

    }
}
