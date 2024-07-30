using AutoMapper;
using Challenge.Application.Features.Clients;
using Challenge.Application.Features.Contacts;
using Challenge.Domain.Features.Contacts;
using Challenge.Domain.Features.Clients;


namespace Challenge.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Client, ClientViewModel>();
            CreateMap<Contact, ContactViewModel>();
        }
    }
}
