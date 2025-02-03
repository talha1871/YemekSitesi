using AutoMapper;
using Base_Model.Model.Entities;
using DtoLayer.Dtos.CategoryDto;

namespace YemekSitesiApi.Mapping
{
    public class CategoryMapping: Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
        }
    }
}
