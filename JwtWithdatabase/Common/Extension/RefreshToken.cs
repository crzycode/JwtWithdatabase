using JwtWithdatabase.Common.Model;
using System.Security.Cryptography;

namespace JwtWithdatabase.Common.Extension
{
    public static class RefreshToken
    {
        public static dynamic GenerateRefreshToken(this ICommon common)
        {
            var refreshToken = new Token
            {
                Tokens = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
                Expired = DateTime.Now.AddMinutes(1),
                Created = DateTime.Now
            };
            return refreshToken;
        }
    }
}
