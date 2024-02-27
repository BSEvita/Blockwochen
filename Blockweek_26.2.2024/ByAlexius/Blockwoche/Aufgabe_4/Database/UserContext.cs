using Aufgabe_4.Models;
using Microsoft.EntityFrameworkCore;

namespace Aufgabe_2.Data.Database;

public class UserContext : DbContext
{
    public DbSet<User> users { get; set; }

    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();
    }
}