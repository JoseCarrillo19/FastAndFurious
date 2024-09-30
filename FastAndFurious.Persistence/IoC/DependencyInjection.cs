using FastAndFurious.Domain.IRepositories;
using FastAndFurious.Persistence.Data;
using FastAndFurious.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FastAndFurious.Persistence.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Registrar repositorios
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IChasisRepository, ChasisRepository>();
            services.AddScoped<IMotorRepository, MotorRepository>();
            services.AddScoped<ICojineraRepository, CojineraRepository>();
            return services;
        }
    }
}
