using FastAndFurious.Domain.Entities;
using FastAndFurious.Domain.IRepositories;
using FastAndFurious.Persistence.Data;

namespace FastAndFurious.Persistence.Repositories
{
    public class ChasisRepository: IChasisRepository
    {
        private readonly ApplicationDbContext _context;

        public ChasisRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Chasis> GetByIdAsync(int id)
        {
            return await _context.Chasis.FindAsync(id);
        }
    }
}
