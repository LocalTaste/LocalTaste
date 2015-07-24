using LocalTaste.Data.Repositories.Interfaces;
using LocalTaste.Domain.POCO;

namespace LocalTaste.Data.Repositories
{
    public class ReviewRepository: BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(LocalTasteDataContext dbContext)
            : base(dbContext)
        {
        }
    }
}
