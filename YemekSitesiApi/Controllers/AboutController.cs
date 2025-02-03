using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using BL_YemekSitesi.Managers.GenericManager.Abstract;
using DtoLayer.Dtos.AboutDto;
using DtoLayer.Dtos.CategoryDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutManager _aboutManager ;

        public AboutController(IAboutManager aboutManager)
        {
            _aboutManager = aboutManager;
        }

        [HttpGet]

        public IActionResult AboutList()
        {
            var values = _aboutManager.TGetListAll();

            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateAbout(CreateAboutDto dto)
        {
            About about = new About
            {
                AboutDescription = dto.AboutDescription,
                AboutImage = dto.AboutImage,
                AboutName = dto.AboutName,
            };
            _aboutManager.TAdd(about);
            return  Ok( "Hakkımda Oluşturuldu"); ;
        }

        

        [HttpPut]

        public IActionResult UpdateAbout (UpdateAboutDto dto)
        {
            About about = new About
            {
                AboutID = dto.AboutID,
                AboutName = dto.AboutName,
                AboutDescription = dto.AboutDescription,
                AboutImage = dto.AboutImage,
            };
            _aboutManager.TUpdate(about);
            return Ok("GÜNCELLENDİ");
        }

        [HttpGet("{id}")]

        public IActionResult GetAbout(int id) 
        {
            var value = _aboutManager.TGetByID(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutManager.TGetByID(id);
            _aboutManager.TDelete(values);
            return Ok("Silindi");

        }
    }
}
