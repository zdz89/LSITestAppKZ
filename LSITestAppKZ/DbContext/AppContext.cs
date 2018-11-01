using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace LSITestApp
{
    public class AppContext : DbContext
    {
        public DbSet<Export> Exports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LSITestDbKZ"].ConnectionString);
        }
    }
}
