using Microsoft.EntityFrameworkCore;
using webappmotostop1.Models;

namespace webappmotostop1.Data
{
    public class WEBASPITSContext : DbContext
    {
        public WEBASPITSContext(DbContextOptions<WEBASPITSContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Moto> Motos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Moto>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}