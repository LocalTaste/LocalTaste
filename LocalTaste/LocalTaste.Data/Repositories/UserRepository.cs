using LocalTaste.Data.Repositories.Interfaces;
using LocalTaste.Domain.POCO;

namespace LocalTaste.Data.Repositories
{
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
        public UserRepository(LocalTasteDataContext dbContext)
            : base(dbContext)
        {
        }
    }
}
