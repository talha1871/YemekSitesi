using AutoMapper;
using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using BL_YemekSitesi.Managers.Concreate;
using DtoLayer.Dtos.DiscountDto;
using DtoLayer.Dtos.FeatureDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureManager _featureManager;

        private readonly IMapper _mapper;
        public FeatureController(IFeatureManager featureManager, IMapper mapper)
        {
            _featureManager = featureManager;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult FeatureList()
        {
            var values = _mapper.Map<List<ResultFeatureDto>>(_featureManager.TGetListAll());
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateFeature(CreateFeatureDto dto)
        {
            var value = _mapper.Map<Feature>(dto);
            _featureManager.TAdd(value);
            return Ok(value);
        }

        [HttpGet("{id}")]

        public IActionResult GetFeature(int id)
        {
            var value = _featureManager.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateFeatureDto dto)
        {
            var value = _mapper.Map<Feature>(dto);
            _featureManager.TUpdate(value);
            return Ok("Güncellendi");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureManager.TGetByID(id);
            _featureManager.TDelete(value);
            return Ok("Silindi");
        }

    }
}
