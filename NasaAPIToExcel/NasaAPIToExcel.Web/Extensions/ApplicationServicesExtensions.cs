using Microsoft.Extensions.DependencyInjection;
using NasaAPIToExcel.Services;
using NasaAPIToExcel.Services.Contracts;

namespace NasaAPIToExcel.Web.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<INASAService, NASAService>();

            return services;
        }
    }
}
