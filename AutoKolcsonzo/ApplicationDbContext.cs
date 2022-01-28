using AutoKolcsonzo.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoKolcsonzo
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Renter> Renters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                @"Data Source = (localdb)\MSSQLLocalDB; " +
                "Initial Catalog = kolcsonzo; " +
                "Integrated Security = True;"
            );

            base.OnConfiguring(options);
        }
    }
}
