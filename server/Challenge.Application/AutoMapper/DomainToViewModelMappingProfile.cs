using AutoMapper;
using Challenge.Application.Features.Boletos;
using Challenge.Domain.Features.Boleto;

namespace Challenge.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<BoletoViewModel, Boleto>();

        }


    }
}
