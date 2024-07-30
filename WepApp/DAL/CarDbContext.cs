using Microsoft.EntityFrameworkCore;
using WepApp.Models;

namespace WepApp.DAL
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-9C59JAU;Database=CarDb;Trusted_Connection=True;TrustServerCertificate=True");
        //}

        public DbSet<Car> Cars { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }


    }
}
