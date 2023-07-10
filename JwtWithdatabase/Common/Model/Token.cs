using System.ComponentModel.DataAnnotations;

namespace JwtWithdatabase.Common.Model
{
    public class Token
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Tokens { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Expired { get; set; }

    }
}
