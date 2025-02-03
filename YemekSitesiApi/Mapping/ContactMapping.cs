using AutoMapper;
using Base_Model.Model.Entities;
using DtoLayer.Dtos.ContactDto;

namespace YemekSitesiApi.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
        }
    }
}
