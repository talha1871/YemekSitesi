using AutoMapper;
using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Concreate;
using DtoLayer.Dtos.AboutDto;

namespace YemekSitesiApi.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
