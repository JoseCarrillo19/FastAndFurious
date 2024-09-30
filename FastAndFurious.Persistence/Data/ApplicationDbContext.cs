using FastAndFurious.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastAndFurious.Persistence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Chasis> Chasis { get; set; }
        public DbSet<Motor> Motor { get; set; }
        public DbSet<Cojinera> Cojinera { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
