using FastAndFurious.Domain.Entities;

namespace FastAndFurious.Domain.IRepositories
{
    public interface IVehicleRepository
    {
        Task<Vehicle> AssembleVehicleAsync(string marca, string color, Chasis chasis, Motor motor, Cojinera cojinera);
    }
}
