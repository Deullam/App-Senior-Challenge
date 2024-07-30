using AutoMapper;
using Challenge.Application.Features.Clients;
using Challenge.Application.Features.Contacts;
using Challenge.Domain.Features.Clients;
using Challenge.Domain.Features.Contacts;

namespace Challenge.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClientViewModel, Client>();
            CreateMap<ContactViewModel, Contact>();
        }


    }
}
