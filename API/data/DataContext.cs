using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
