using Aufgabe_2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Aufgabe_2.Data.Database;

public class BookContext : DbContext
{
    public DbSet<Book> books { get; set; }

    public BookContext(DbContextOptions<BookContext> options) : base(options)
    {
        
    }
}