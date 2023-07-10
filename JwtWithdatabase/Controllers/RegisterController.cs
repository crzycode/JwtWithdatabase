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
    public class RegisterController : ControllerBase
    {
        private readonly ICommon common;
        private readonly DataContext db;
        public RegisterController(ICommon common, DataContext db)
        {
            this.common = common;
            this.db = db;
                
        }
        [HttpPost]
        public dynamic Register_user(Users user)
        {
            common.Hash(user.Password, out byte[] passwordHash, out byte[] salt);
            userdata users = new userdata();
            users.Username = user.Username;
            users.Password = passwordHash;
            users.PasswordSalt = salt;
            db.users.Add(users);
            db.SaveChanges();
            return "Success";
           
        }

    }
}

