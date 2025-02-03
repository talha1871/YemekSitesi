using AutoMapper;
using Base_Model.Model.Entities;
using DtoLayer.Dtos.FeatureDto;

namespace YemekSitesiApi.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature,  UpdateFeatureDto>().ReverseMap();
        }
    }
}
