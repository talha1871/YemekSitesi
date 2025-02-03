using AutoMapper;
using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using DtoLayer.Dtos.TestimonialDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialManager _testimonialManager;

        private readonly IMapper _mapper;
        public TestimonialController(ITestimonialManager testimonialManager, IMapper mapper)
        {
            _testimonialManager = testimonialManager;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult TestimonialList()
        {
            var values = _mapper.Map<List<ResultTestimonialDto>>(_testimonialManager.TGetListAll());
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateTestimonial(CreateTestimonialDto dto)
        {
            var value = _mapper.Map<Testimonial>(dto);
            _testimonialManager.TAdd(value);
            return Ok(value);
        }

        [HttpGet("{id}")]

        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialManager.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateTestimonialDto dto)
        {
            var value = _mapper.Map<Testimonial>(dto);
            _testimonialManager.TUpdate(value);
            return Ok("Güncellendi");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialManager.TGetByID(id);
            _testimonialManager.TDelete(value);
            return Ok("Silindi");
        }
    }
}
