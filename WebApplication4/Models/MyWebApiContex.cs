using Microsoft.EntityFrameworkCore;


namespace WebApplication4.Models
{
    public class MyWebApiContex : DbContext
    {
        public MyWebApiContex(DbContextOptions<MyWebApiContex> options) : base(options)
        {
        }
        public DbSet<User> User { get; set;}
    }
}
