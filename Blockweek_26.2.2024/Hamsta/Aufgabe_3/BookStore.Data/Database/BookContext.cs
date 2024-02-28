using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.Database;

public class BookContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    public BookContext(DbContextOptions<BookContext> options) : base(options)
    {
        
    }
}