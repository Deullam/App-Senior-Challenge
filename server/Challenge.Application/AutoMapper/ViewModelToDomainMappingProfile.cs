using AutoMapper;
using Challenge.Application.Features.Boletos;
using Challenge.Domain.Features.Boleto;

namespace Challenge.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Boleto, BoletoViewModel>();
        }
    }
}
