using Microsoft.EntityFrameworkCore;

namespace Convention.Models
{
    public class ConventionContext : DbContext
    {
        public DbSet<Convention> Conventions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=convention;Username=postgres;Password=1");
        }
    }
}
