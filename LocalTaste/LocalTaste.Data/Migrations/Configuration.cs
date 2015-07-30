using LocalTaste.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalTaste.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LocalTasteDataContext>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LocalTasteDataContext context)
        {

            //List<User> seededUsers = new List<User>
            //{
            //    new User{ Name = "User One", Email = "UserOne@mail.com", UserLogin = "User1", DateCreated = DateTime.UtcNow }
            //};

            //seededUsers.ForEach(u => u.Password = BCrypt.Net.BCrypt.HashPassword("password", 12));
            //seededUsers.ForEach(u => context.Set<User>().AddOrUpdate(x => x.Email, u));

            //context.SaveChanges();

            //List<Restaurant> seededRestaurants = new List<Restaurant>()
            //{
            //    new Restaurant() {Name = "PF Changs", Address = new Address() { City = "Boca Raton", State = "FL", Street = "Chang Street", Zip ="33065" }, CloseTime = "8PM", OpenTime = "10AM", PhoneNumber = "999-111-2323", PriceRating = 3, WebsiteUrl = "http://www.pfchangs.com" },
            //    new Restaurant() {Name = "Roccos Tacos", Address = new Address() { City = "Boca Raton", State = "FL", Street = "Rocco Street", Zip ="33065" }, CloseTime = "8PM", OpenTime = "10AM", PhoneNumber = "999-234-2312", PriceRating = 3, WebsiteUrl = "http://www.roccos.com" },
            //    new Restaurant() {Name = "Cheescake Facotry", Address = new Address() { City = "Boca Raton", State = "FL", Street = "Factory Street", Zip ="33065" }, CloseTime = "8PM", OpenTime = "10AM", PhoneNumber = "999-643-7890", PriceRating = 3, WebsiteUrl = "http://www.cheescake.com" }
            //};

            //List<Review> seededReviews = new List<Review>()
            //{
            //    new Review() { Message = "This place is awesome!", StarRating = 3, User = seededUsers.First(), RestaurantId = 1 },
            //    new Review() { Message = "Defiitely coming back here!", StarRating = 3, User = seededUsers.First(), RestaurantId = 2 },
            //    new Review() { Message = "Best Food in town!", StarRating = 3, User = seededUsers.First(), RestaurantId = 1 },
            //    new Review() { Message = "Recommending this place to all my firends!", StarRating = 3, User = seededUsers.First(), RestaurantId = 2 }
            //};

            //seededRestaurants.ForEach(r => context.Set<Restaurant>().AddOrUpdate(x => x.Name, r));
            //seededReviews.ForEach(r => context.Set<Review>().AddOrUpdate(x => x.Id, r));


            //context.SaveChanges();
        }
    }
}
