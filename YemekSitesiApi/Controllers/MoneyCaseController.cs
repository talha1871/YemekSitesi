using BL_YemekSitesi.Managers.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCaseController : ControllerBase
    {
        private readonly IMoneyCaseManager _moneyCaseManager;

        public MoneyCaseController(IMoneyCaseManager moneyCaseManager)
        {
            _moneyCaseManager = moneyCaseManager;
        }

        [HttpGet("TotalMoneyCaseAmount")]
        public IActionResult GetTotalMoneyCaseAmount()
        {
            return Ok(_moneyCaseManager.TTotalMoneyCaseAmount());
        }
    }
}
