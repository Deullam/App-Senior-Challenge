using SimpleInjector;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Challenge.Application.Features.Clients;
using Challenge.Application.Features.Contacts;

namespace Challenge.Infra.IoC.Features.Containers
{
    public static class NativeInjectorBootStrapper
    {


        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IContactService, ContactService>();


        }
    }
}
