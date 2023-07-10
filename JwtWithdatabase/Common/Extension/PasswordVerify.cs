using System.Security.Cryptography;

namespace JwtWithdatabase.Common.Extension
{
    public static class PasswordVerify
    {
        public static bool Verify(this ICommon common, string password,  byte[] passwordHash,  byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA256(passwordSalt))
            {
                var compute = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
               
                return compute.SequenceEqual(passwordHash);
            }
        }
    }
}
