using Microsoft.EntityFrameworkCore;

namespace peakToxic.API.Models;

public class MoviesAPIContext : DbContext
{
    public MoviesAPIContext(DbContextOptions<MoviesAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }
}