using Microsoft.Extensions.DependencyInjection;
using Wfl.Domain;
using Wfl.Domain.Validators;

namespace Wfl.Application
{
    // we're doing this so we can keep as many structures (interfaces) and implementations
    // hidden to the consumer
    //
    // Application as a whole will be visible to Consumers (API), but the Domain is only visible to Application
    // and other Applications
    public static class ServerExtensions
    {
        public static void AddApplicationLayer(
            this IServiceCollection services)
        {
            services.AddSingleton<SampleRequestValidator>();
            services.AddScoped<ISampleDomainService, SampleDomainService>();
            services.AddScoped<ISamplePortService, SamplePortService>();
        }
    }
}
