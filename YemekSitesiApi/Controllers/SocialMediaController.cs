using AutoMapper;
using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using DtoLayer.Dtos.SocialMediaDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaManager _socialMediaManager;

        private readonly IMapper _mapper;
        public SocialMediaController(ISocialMediaManager socialMediaManager, IMapper mapper)
        {
            _socialMediaManager = socialMediaManager;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult SocialMediaList()
        {
            var values = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaManager.TGetListAll());
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateSocialMedia(CreateSocialMediaDto dto)
        {
            var value = _mapper.Map<SocialMedia>(dto);
            _socialMediaManager.TAdd(value);
            return Ok(value);
        }

        [HttpGet("{id}")]

        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaManager.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateSocialMediaDto dto)
        {
            var value = _mapper.Map<SocialMedia>(dto);
            _socialMediaManager.TUpdate(value);
            return Ok("Güncellendi");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaManager.TGetByID(id);
            _socialMediaManager.TDelete(value);
            return Ok("Silindi");
        }
    }
}
