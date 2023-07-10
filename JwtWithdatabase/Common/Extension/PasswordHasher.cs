using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace JwtWithdatabase.Common.Extension
{
    public static class PasswordHasher
    {
        public static void Hash(this ICommon common, string password, out byte[] passwordHash, out byte[] passwordSalt)
        {

                using (var hmac = new HMACSHA256())
                {
                    passwordSalt = hmac.Key;
                    passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                }


            
        }
    }
}
