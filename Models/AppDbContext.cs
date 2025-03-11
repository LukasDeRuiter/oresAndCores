using Microsoft.EntityFrameworkCore;

namespace oresAndCores.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ore> Ores { get; set; } // Ensure you have an 'Ore' model
    }
}