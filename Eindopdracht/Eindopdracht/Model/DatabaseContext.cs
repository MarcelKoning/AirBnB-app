using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht.Model;
using Microsoft.EntityFrameworkCore;

namespace Eindopdracht.Model
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=(localDb)\\MSSQLLocalDB;Initial Catalog=AirBNB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            options.UseLazyLoadingProxies();

            options.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Landlord>().HasData(
                new Landlord { FirstName = "Marcel", LastName = "Koning", Id = 1},
                new Landlord { FirstName = "Christian", LastName = "Koning", Id = 2}
            );

            builder.Entity<House>().HasData(
                new { HouseName = "test2", HouseDescription = "Test omschrijving", HouseType = House.HouseTypes.Apartment , MaxPerson = 1, Price = 90f, BedroomTotal = 4, BedTotal = 8, BathroomTotal = 2, SmokingAllowed = false, Id = 2, LandlordId = 1, Streetname="teststraat", HouseNumber="12", City="Almere", PostalCode="1234AB", Country="Netherlands"}
            );

            builder.Entity<House>()
                .HasOne(h => h.Landlord)
                .WithMany(l => l.Houses)
                .IsRequired() 
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
