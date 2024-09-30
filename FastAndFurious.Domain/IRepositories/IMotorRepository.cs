using FastAndFurious.Domain.Entities;

namespace FastAndFurious.Domain.IRepositories
{
    public interface IMotorRepository
    {
        Task<Motor> GetByIdAsync(int id);
    }
}
