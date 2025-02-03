using AutoMapper;
using Base_Model.Model.Entities;
using DtoLayer.Dtos.ProductDto;

namespace YemekSitesiApi.Mapping
{
    public class ProductMapping: Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategory>().ReverseMap();
        }
    }
}
