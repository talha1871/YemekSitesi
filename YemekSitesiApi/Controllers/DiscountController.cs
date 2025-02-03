using AutoMapper;
using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using BL_YemekSitesi.Managers.Concreate;
using DAL_YemekSitesi.Repositories.Concreate;
using DtoLayer.Dtos.DiscountDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountManager _discountManager;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountManager discountManager, IMapper mapper)
        {
            _discountManager = discountManager;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult DiscountList()
        {
            var values = _mapper.Map<List<ResultDiscountDto>>(_discountManager.TGetListAll());
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetDiscount(int id)
        {
            var value =_discountManager.TGetByID(id);
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateDiscount(CreateDiscountDto dto)
        {
            var value = _mapper.Map<Discount>(dto);
            _discountManager.TAdd(value);
            return Ok(value);
        }


        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto dto)
        {
            var value = _mapper.Map<Discount>(dto);
            _discountManager.TUpdate(value);
            return Ok("Güncellendi");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value =_discountManager.TGetByID(id);
            _discountManager.TDelete(value);
            return Ok("Silindi");
        }
    }
}
