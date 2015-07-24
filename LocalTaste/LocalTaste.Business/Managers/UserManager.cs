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
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public User Get(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
