using System.ComponentModel.DataAnnotations;

namespace JwtWithdatabase.DbModels
{
    public class userdata
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
