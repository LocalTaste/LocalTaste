using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalTaste.Mvc.Services
{
    public class BCPasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            int workfactor = 12;
            var hash = BCrypt.Net.BCrypt.HashPassword(password, workfactor);
            return hash;
        }

        public PasswordVerificationResult VerifyHashedPassword(string hashedPassword, string providedPassword)
        {
            bool isValid = BCrypt.Net.BCrypt.Verify(providedPassword, hashedPassword);
            return isValid ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
        }
    }
}