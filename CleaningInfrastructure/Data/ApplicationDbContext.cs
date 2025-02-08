using Microsoft.EntityFrameworkCore;
using CleaningDomain.Entities;

namespace CleaningInfrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Map> Maps { get; set; }

        // Marking this method as override is recommended.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add your model configurations here if needed.
        }
    }
}
