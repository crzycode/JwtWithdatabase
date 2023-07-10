namespace JwtWithdatabase.Common
{
    public interface ICommon
    {
        public dynamic createToken(string username, int minute);
    }
}
