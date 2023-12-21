using BlockSeite.Models;
using Microsoft.EntityFrameworkCore;

namespace BlockSeite.Data
{
    public class MyDbContext : DbContext
    {

        public MyDbContext (DbContextOptions options) : base (options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Role>().ToTable("Roles");
        }
    }
}
