using LocalTaste.Business.Managers.Interfaces;
using LocalTaste.Data.Repositories.Interfaces;
using LocalTaste.Domain.POCO;
using System;

namespace LocalTaste.Business.Managers
{
    public class RestaurantManager : IRestaurantManager
    {
        private readonly IRestaurantRepository RestaurantRepo;

        public RestaurantManager(IRestaurantRepository restaurantRepo)
        {
            RestaurantRepo = restaurantRepo;
        }

        public Restaurant Add(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Restaurant Get(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Restaurant entity)
        {
            throw new NotImplementedException();
        }
    }
}
