using HotelListing.API.Core.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Core.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
