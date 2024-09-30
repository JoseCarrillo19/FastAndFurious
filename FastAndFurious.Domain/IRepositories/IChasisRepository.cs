using FastAndFurious.Domain.Entities;

namespace FastAndFurious.Domain.IRepositories
{
    public interface IChasisRepository
    {
        Task<Chasis> GetByIdAsync(int id);
    }
}
