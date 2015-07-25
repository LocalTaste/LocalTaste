using LocalTaste.Business.Managers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalTaste.Domain.POCO;
using LocalTaste.Data.Repositories.Interfaces;

namespace LocalTaste.Business.Managers
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository UserRepo;

        public UserManager(IUserRepository userRepo)
        {
            UserRepo = userRepo;
        }

        public User Add(User entity)
        {
            UserRepo.Add(entity);
            return entity;
        }

        public void Delete(int Id)
        {
            var user = UserRepo.Get(Id);
            UserRepo.Delete(user);
        }

        public User Get(string username)
        {
            return UserRepo.FirstOrDefault(u => u.UserLogin == username);
        }

        public User Get(int Id)
        {
            return UserRepo.Get(Id);
        }

        public User GetByEmail(string email)
        {
            return UserRepo.FirstOrDefault(u => u.Email == email);
        }

        public void Update(User entity)
        {
            UserRepo.Update(entity);
        }
    }
}
