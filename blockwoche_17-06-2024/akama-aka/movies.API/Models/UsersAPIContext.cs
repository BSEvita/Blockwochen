using Microsoft.EntityFrameworkCore;

namespace peakToxic.API.Models;

public class UsersAPIContext : DbContext
{
    public UsersAPIContext(DbContextOptions<UsersAPIContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}