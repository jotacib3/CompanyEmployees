using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyEmployees.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection service) =>
            service.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                 builder.AllowAnyOrigin()
                 .AllowAnyHeader()
                 .AllowAnyMethod());
            });

        public static IServiceCollection ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options => {});

    }
}
