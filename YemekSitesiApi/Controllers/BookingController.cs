using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using DtoLayer.Dtos.BookingDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YemekSitesiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingManager _bookingManager;

        public BookingController(IBookingManager bookingManager)
        {
            _bookingManager = bookingManager;
        }

        [HttpGet]

        public IActionResult BookingList() 
        { 
            var values =_bookingManager.TGetListAll();
           return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingManager.TGetByID(id);
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateBooking(CreateBookingDto dto)
        {
            Booking booking = new Booking()
            {
                BookingName = dto.BookingName,
                BookingDate = dto.BookingDate,
                BookingDescription = dto.BookingDescription, //*?
                BookingEmail = dto.BookingEmail,
                BookingPhone = dto.BookingPhone,
                PersonCount = dto.PersonCount,
            };
            _bookingManager.TAdd(booking);
            return Ok("Oluşturuldu");

        }
        [HttpPut]

        public IActionResult UpdateBooking(UpdateBookingDto dto)
        {
            Booking booking = new Booking()
            {

                BookingName = dto.BookingName,
                BookingDate = dto.BookingDate,
                BookingDescription = dto.BookingDescription, //*?
                BookingEmail = dto.BookingEmail,
                BookingPhone = dto.BookingPhone,
                PersonCount = dto.PersonCount,
            };
            
            _bookingManager.TUpdate(booking);
            return Ok("Güncellendi!");
        }



        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id) 
        {

            var value = _bookingManager.TGetByID(id);
            _bookingManager.TDelete(value);
            return Ok("Rezervasyon Silindi.");
        }

       
    
    }
}
