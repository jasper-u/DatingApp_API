using DatingApp_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp_API.Data
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}
