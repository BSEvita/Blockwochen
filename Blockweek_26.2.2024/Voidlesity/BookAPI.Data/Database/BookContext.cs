using BookAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Data.Database;

public class BookContext : DbContext
{
    public DbSet<Book> books { get; set; }

    public BookContext(DbContextOptions<BookContext> options) : base(options)
    {
        
    }
}