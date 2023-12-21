using BlockSeite.Models;
using Microsoft.EntityFrameworkCore;

namespace BlockSeite.Data
{
    public class MyDbContext : DbContext
    {

        public MyDbContext (DbContextOptions options) : base (options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
        }
        public DbSet<BlockSeite.Models.Role> Role { get; set; } = default!;
    }
}
