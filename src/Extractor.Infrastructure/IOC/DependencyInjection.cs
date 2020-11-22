using Extractor.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Extractor.Infrastructure.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IEmailService, EmailService>();
            return services;
        }
    }
}
