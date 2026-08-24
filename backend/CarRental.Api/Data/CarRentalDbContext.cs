using CarRental.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Api.Data;

public class CarRentalDbContext : DbContext
{
    public CarRentalDbContext(DbContextOptions<CarRentalDbContext> options)
        :base(options)
    {
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .Property( c => c.PricePerDay)
            .HasPrecision(10, 2);
        
        modelBuilder.Entity<Reservation>()
            .Property( r => r.TotalPrice)
            .HasPrecision(10, 2);
            
        CarSeedData.Seed(modelBuilder);
    }

}