using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace Extractor.Infrastructure.Swagger
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Extractor",
                    Description = "Extractor é uma ferramenta online pequena e fácil que pode extrair diversos formatos.",
                    TermsOfService = new Uri("https://Extractor.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "SocialMente",
                        Email = string.Empty,
                        Url = new Uri("https://twitter.com/Extractor"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use sob licença",
                        Url = new Uri("https://Extractor.com/license"),
                    }
                });
            });
            return services;

        }
        public static IApplicationBuilder AddSwagger( this IApplicationBuilder app)
        {

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Extractor");
            });
            return app;

        }
    }
}
