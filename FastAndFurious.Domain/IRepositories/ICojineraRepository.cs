
using FastAndFurious.Domain.Entities;

namespace FastAndFurious.Domain.IRepositories
{
    public interface ICojineraRepository
    {
        Task<Cojinera> GetByIdAsync(int id);
    }
}
