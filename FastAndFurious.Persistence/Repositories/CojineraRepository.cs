using FastAndFurious.Domain.Entities;
using FastAndFurious.Domain.IRepositories;
using FastAndFurious.Persistence.Data;

namespace FastAndFurious.Persistence.Repositories
{
    internal class CojineraRepository: ICojineraRepository
    {
        private readonly ApplicationDbContext _context;

        public CojineraRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Cojinera> GetByIdAsync(int id)
        {
            return await _context.Cojinera.FindAsync(id);
        }
    }
}
