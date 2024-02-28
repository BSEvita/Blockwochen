using BookStoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookStoreMVC.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Book { get; set; } = default!;

        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
    }
}
