using AutoMapper;
using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using DtoLayer.Dtos.ContactDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactManager _contactManager;
        private readonly IMapper _mapper;

        public ContactController(IMapper mapper, IContactManager contactManager)
        {
            _mapper = mapper;
            _contactManager = contactManager;
        }


        [HttpGet]

        public IActionResult ContactList()
        { 
            var list = _contactManager.TGetListAll();
            return Ok(list);
        }

        [HttpPost]

        public IActionResult CreateContact(CreateContactDto dto)
        {
            var value = _mapper.Map<Contact>(dto);
            _contactManager.TAdd(value);
            return Ok("Contact Eklendi");
        }
        [HttpPut]

        public IActionResult UpdateContact(UpdateContactDto dto)
        {
            var value =_mapper.Map<Contact>(dto);
            _contactManager.TUpdate(value);
            return Ok("Güncellendi");
        
        }

        [HttpGet("{id}")]

        public IActionResult GetContact(int id)
        { 
            var value = _contactManager.TGetByID(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteContact(int id)
        {
            var value = _contactManager.TGetByID(id);
            _contactManager.TDelete(value);
            return Ok("Silindi");
        }


    }
}
