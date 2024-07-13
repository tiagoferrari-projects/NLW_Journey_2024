using Journey.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Journey.Infrastructure
{
    public class JourneyDbContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=JOURNEY;User Id=sa;Password=1234;TrustServerCertificate=True");
        }
    }
}
