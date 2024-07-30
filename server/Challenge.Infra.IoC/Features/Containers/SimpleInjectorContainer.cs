using SimpleInjector;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Challenge.Application.Features.Boletos;

namespace Challenge.Infra.IoC.Features.Containers
{
    public static class NativeInjectorBootStrapper
    {


        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<IBoletoService, BoletoService>();
        }
    }
}
