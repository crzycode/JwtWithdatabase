namespace JwtWithdatabase.DbModels
{
    public class JwtToken
    {
        public string Username { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime ExpiredToken { get; set; }
    }
}
