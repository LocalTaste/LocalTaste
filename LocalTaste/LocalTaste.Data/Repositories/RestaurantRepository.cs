using LocalTaste.Data.Repositories.Interfaces;
using LocalTaste.Domain.POCO;

namespace LocalTaste.Data.Repositories
{
    public class RestaurantRepository:BaseRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(LocalTasteDataContext dbContext)
            : base(dbContext)
        {
        }
    }
}
