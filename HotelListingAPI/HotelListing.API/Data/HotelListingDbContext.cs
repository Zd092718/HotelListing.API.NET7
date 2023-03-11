using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "United States",
                    ShortName = "US"
                },
                new Country
                {
                    Id = 2,
                    Name = "Mexico",
                    ShortName = "MX"
                },
                new Country
                {
                    Id = 3,
                    Name = "Canada",
                    ShortName = "CN"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Best Western",
                    Address = "Nebraska",
                    CountryId = 1,
                    Rating = 3
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Sandals Resort",
                    Address = "Oaxaca",
                    CountryId = 2,
                    Rating = 4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hilton",
                    Address = "Vancouver",
                    CountryId = 3,
                    Rating = 5
                }
            );
        }
    }
}
