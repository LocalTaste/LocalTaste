using LocalTaste.Domain.POCO;
using System.Collections.Generic;

namespace LocalTaste.Business.Managers.Interfaces
{
    public interface IRestaurantManager
    {
        Restaurant Get(int Id);
        Restaurant Add(Restaurant entity);
        List<Restaurant> Search(string input);
        void Update(Restaurant entity);
        void Delete(int Id);
    }
}
