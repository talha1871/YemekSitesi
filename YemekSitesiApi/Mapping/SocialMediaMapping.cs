using AutoMapper;
using Base_Model.Model.Entities;
using DtoLayer.Dtos.SocialMediaDto;

namespace YemekSitesiApi.Mapping
{
    public class SocialMediaMapping: Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();   
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
        }
    }
}
