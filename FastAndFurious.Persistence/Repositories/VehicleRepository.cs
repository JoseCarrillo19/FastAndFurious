using FastAndFurious.Domain.Entities;
using FastAndFurious.Domain.IRepositories;
using FastAndFurious.Persistence.Data;

namespace FastAndFurious.Persistence.Repositories
{
    public class VehicleRepository: IVehicleRepository
    {
        private readonly ApplicationDbContext _context;

        public VehicleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Vehicle> AssembleVehicleAsync(string marca, string color, Chasis chasis, Motor motor, Cojinera cojinera)
        {
            var vehicle = new Vehicle
            {
                Marca = marca,
                Color = color,
                FechaEnsamblaje = DateTime.Now,
                NumeroEnsamblaje = new Random().Next(1000, 9999), 
                Chasis = chasis,
                Motor = motor,
                Cojinera = cojinera
            };

            _context.Vehicle.Add(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }
    }
}
