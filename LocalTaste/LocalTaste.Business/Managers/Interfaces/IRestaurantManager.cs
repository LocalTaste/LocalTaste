using LocalTaste.Domain.POCO;

namespace LocalTaste.Business.Managers.Interfaces
{
    public interface IRestaurantManager
    {
        Restaurant Get(int Id);
        Restaurant Add(Restaurant entity);
        void Update(Restaurant entity);
        void Delete(int Id);
    }
}
