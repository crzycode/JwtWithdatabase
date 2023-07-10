using JwtWithdatabase.Common.Model;
using JwtWithdatabase.DbModels;
using Microsoft.EntityFrameworkCore;

namespace JwtWithdatabase.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
       public DbSet<userdata> users { get; set; }
       public DbSet<Token> tokens { get; set; }
    }
}
