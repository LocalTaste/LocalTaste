using LocalTaste.Mvc.Models;
using Microsoft.AspNet.Identity;

namespace LocalTaste.Mvc.Services
{
    public interface IAuthenticationService : IUserStore<CustomIdentityUser, int>, IUserPasswordStore<CustomIdentityUser, int>, IUserLoginStore<CustomIdentityUser, int>, IUserClaimStore<CustomIdentityUser, int>, IUserRoleStore<CustomIdentityUser, int>, IUserLockoutStore<CustomIdentityUser, int>, IUserEmailStore<CustomIdentityUser, int>
    {
    }
}
