using JwtWithdatabase.Common;
using JwtWithdatabase.Common.Extension;
using JwtWithdatabase.Data;
using JwtWithdatabase.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtWithdatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ICommon common;
        private readonly IConfiguration configuration;
        private readonly DataContext db;
        public LoginController(ICommon common, DataContext db)
        {
            this.common = common;
            this.db = db;

        }

        [HttpPost]
        public dynamic Login(Users user)
        {
            var data = db.users.Where(c => c.Username == user.Username).ToList();
            if(data.Count > 0)
            {
                var ischeck = common.Verify(user.Password, data[0].Password, data[0].PasswordSalt);
                if (ischeck)
                {
                 var jwt = common.createToken(data[0].Username,5);
                    return jwt;
                }
                else
                {
                    return "Incorect Password";
                }
            }
            else
            {
                return "User not founnd";
            }
        


        }
    }
}
