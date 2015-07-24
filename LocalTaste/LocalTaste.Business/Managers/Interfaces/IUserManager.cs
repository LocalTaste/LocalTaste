using LocalTaste.Domain.POCO;

namespace LocalTaste.Business.Managers.Interfaces
{
    public interface IUserManager
    {
        User Get(int Id);
        User Add(User entity);
        void Update(User entity);
        void Delete(int Id);
    }
}
