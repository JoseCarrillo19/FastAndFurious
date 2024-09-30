using FastAndFurious.Application.IServices;
using FastAndFurious.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FastAndFurious.Application.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IVehicleService, VehicleService>();
            return services;
        }
    }
}
