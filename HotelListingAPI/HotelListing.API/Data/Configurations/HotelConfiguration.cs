using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {

            builder.HasData(
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
