using AutoMapper;
using BL_YemekSitesi.Managers.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderManager _sliderManager;

        
        public SliderController(ISliderManager sliderManager, IMapper mapper)
        {
            _sliderManager = sliderManager;
            
        }

        [HttpGet]

        public IActionResult SliderList()
        {
            return Ok(_sliderManager.TGetListAll());
        }



    }
}
