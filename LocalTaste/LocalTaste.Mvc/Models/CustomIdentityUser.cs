using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace LocalTaste.Mvc.Models
{
    public class CustomIdentityUser : IdentityUser, IUser<int>
    {
        [DataMember]
        new public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string UserLogin { get; set; }

        [DataMember]
        new public string Email { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<CustomIdentityUser, int> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
}