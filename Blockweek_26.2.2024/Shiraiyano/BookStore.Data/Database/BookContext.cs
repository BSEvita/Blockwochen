﻿using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookStore.Data.Database;

public class BookContext : DbContext
{
    public DbSet<Books> Books { get; set; }

    public BookContext(DbContextOptions<BookContext> options) : base(options)
    {

    }
}