using FastAndFurious.Domain.Entities;
using FastAndFurious.Domain.IRepositories;
using FastAndFurious.Persistence.Data;

namespace FastAndFurious.Persistence.Repositories
{
    internal class MotorRepository : IMotorRepository
    {
        private readonly ApplicationDbContext _context;

        public MotorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Motor> GetByIdAsync(int id)
        {
            return await _context.Motor.FindAsync(id);
        }
    }
}
