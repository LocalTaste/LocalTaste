using AutoMapper;
using LocalTaste.Business.Managers.Interfaces;
using LocalTaste.Domain.POCO;
using LocalTaste.Mvc.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace LocalTaste.Mvc.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserManager _userService;

        public AuthenticationService(IUserManager userMgr)
        {
            _userService = userMgr;
        }

        #region UserStore
        public Task CreateAsync(CustomIdentityUser user)
        {
            var poco = Mapper.Map<User>(user);
            var result = _userService.Add(poco);
            return Task.FromResult(Mapper.Map<CustomIdentityUser>(result));
        }

        public Task DeleteAsync(CustomIdentityUser user)
        {
            return Task.Factory.StartNew(() => _userService.Delete(user.Id));
        }

        public Task<CustomIdentityUser> FindByIdAsync(int userId)
        {
            return Task.FromResult(Mapper.Map<CustomIdentityUser>(_userService.Get(userId)));
        }

        public Task<CustomIdentityUser> FindByNameAsync(string userName)
        {
            return Task.FromResult(Mapper.Map<CustomIdentityUser>(_userService.Get(userName)));
        }

        public Task UpdateAsync(CustomIdentityUser user)
        {
            var poco = Mapper.Map<User>(user);
            return Task.Factory.StartNew(() => _userService.Update(poco));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

        #region UserPasswordStore
        public Task<string> GetPasswordHashAsync(CustomIdentityUser user)
        {
            return Task.FromResult(user.Password);
        }

        public Task<bool> HasPasswordAsync(CustomIdentityUser user)
        {
            return Task.FromResult(true);
        }

        public Task SetPasswordHashAsync(CustomIdentityUser user, string passwordHash)
        {
            return Task.Factory.StartNew(() => user.Password = passwordHash);
        }
        #endregion

        #region UserLoginStore
        public Task AddLoginAsync(CustomIdentityUser user, UserLoginInfo login)
        {
            throw new NotImplementedException();
        }

        public Task<CustomIdentityUser> FindAsync(UserLoginInfo login)
        {
            throw new NotImplementedException();
        }

        public Task<IList<UserLoginInfo>> GetLoginsAsync(CustomIdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task RemoveLoginAsync(CustomIdentityUser user, UserLoginInfo login)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region UserClaimsStore
        public Task AddClaimAsync(CustomIdentityUser user, Claim claim)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Claim>> GetClaimsAsync(CustomIdentityUser user)
        {
            IList<Claim> userClaims = new List<Claim>();

            userClaims.Add(new Claim("Id", user.Id.ToString(), DefaultAuthenticationTypes.ExternalBearer));

            userClaims.Add(new Claim("Name", user.Name));

            userClaims.Add(new Claim("Email", user.Email));

            return Task.FromResult(userClaims);
        }

        public Task RemoveClaimAsync(CustomIdentityUser user, Claim claim)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region UserRoleStore
        public Task AddToRoleAsync(CustomIdentityUser user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> GetRolesAsync(CustomIdentityUser user)
        {
            IList<string> tempRoles = new List<string>() { "user" };

            return Task.FromResult(tempRoles);
        }

        public Task<bool> IsInRoleAsync(CustomIdentityUser user, string roleName)
        {
            return Task.FromResult(true);
        }

        public Task RemoveFromRoleAsync(CustomIdentityUser user, string roleName)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region UserLockoutStore
        public Task<int> GetAccessFailedCountAsync(CustomIdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetLockoutEnabledAsync(CustomIdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task<DateTimeOffset> GetLockoutEndDateAsync(CustomIdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task<int> IncrementAccessFailedCountAsync(CustomIdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task ResetAccessFailedCountAsync(CustomIdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task SetLockoutEnabledAsync(CustomIdentityUser user, bool enabled)
        {
            throw new NotImplementedException();
        }

        public Task SetLockoutEndDateAsync(CustomIdentityUser user, DateTimeOffset lockoutEnd)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region UserEmailStore
        public Task<CustomIdentityUser> FindByEmailAsync(string email)
        {
            return Task.FromResult(Mapper.Map<CustomIdentityUser>(_userService.GetByEmail(email)));
        }

        public Task<string> GetEmailAsync(CustomIdentityUser user)
        {
            return Task.FromResult(user.Email);
        }

        public Task<bool> GetEmailConfirmedAsync(CustomIdentityUser user)
        {
            return Task.FromResult(true);
        }

        public Task SetEmailAsync(CustomIdentityUser user, string email)
        {
            return Task.Factory.StartNew(() => user.Email = email);
        }

        public Task SetEmailConfirmedAsync(CustomIdentityUser user, bool confirmed)
        {
            return Task.Factory.StartNew(() => true);
        }
        #endregion
    }
}