using AutoMapper;
using Base_Model.Model.Entities;
using DtoLayer.Dtos.BookingDto;

namespace YemekSitesiApi.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
        }
    }
}
