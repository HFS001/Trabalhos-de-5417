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
    }
}