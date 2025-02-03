using AutoMapper;
using Base_Model.Model.Entities;
using DtoLayer.Dtos.DiscountDto;

namespace YemekSitesiApi.Mapping
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount,  UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
        
        }
    }
}
