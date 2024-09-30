using FastAndFurious.Domain.Entities;

namespace FastAndFurious.Application.IServices
{
    public interface IVehicleService
    {
        Task<Vehicle> AssembleVehicleAsync(string marca, string color, int chasisId, int motorId, int cojineraId);
    }
}
