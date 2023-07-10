using JwtWithdatabase.Common.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace JwtWithdatabase.Common
{
    public class _Common : ICommon
    {
        private readonly IConfiguration configuration;
        private readonly DbContext db;
        public _Common(IConfiguration configuration,DbContext db)
        {
                this.configuration = configuration;
            this.db = db;
        }
        public  dynamic createToken(string username, int minute)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Admin")

            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                configuration.GetSection("AppSetting:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(minute),
                signingCredentials: creds

                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
           
            
            return jwt;
        }
    }
}
