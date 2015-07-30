using LocalTaste.Business.Managers.Interfaces;
using LocalTaste.Data.Repositories.Interfaces;
using LocalTaste.Domain.POCO;
using System;
using System.Collections.Generic;

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
            RestaurantRepo.Add(entity);
            return entity;
        }

        public void Delete(int Id)
        {
            var poco = RestaurantRepo.Get(Id);
            RestaurantRepo.Delete(poco);
        }

        public Restaurant Get(int Id)
        {
            return RestaurantRepo.Get(Id);
        }

        public List<Restaurant> Search(string input)
        {
            throw new NotImplementedException();
        }

        public void Update(Restaurant entity)
        {
            RestaurantRepo.Update(entity);
        }
    }
}
