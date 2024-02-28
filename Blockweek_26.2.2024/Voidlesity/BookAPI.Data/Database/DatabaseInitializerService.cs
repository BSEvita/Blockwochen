using BookAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Data.Database;

public class DatabaseInitializerService
{
    private readonly BookContext _context;

    public DatabaseInitializerService(BookContext context)
    {
        _context = context;
    }

    public void Initialize()
    {
        SeedBooks();
    }
    
    public void SeedBooks()
    {
        foreach (Book newBook in _newBooks)
        {
            _context.books.Add(newBook);
        }

        _context.SaveChanges();
    }

    private readonly List<Book> _newBooks =
    [
        new Book
        {
            Id = 1, Title = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", PublicationYear = 1997, CallNumber = "HP12345",
            IsAvailable = true
        },

        new Book
        {
            Id = 2, Title = "Harry Potter and the Chamber of Secrets", Author = "J.K. Rowling", PublicationYear = 1998, CallNumber = "HP23456",
            IsAvailable = false
        },

        new Book
        {
            Id = 3, Title = "Harry Potter and the Prisoner of Azkaban", Author = "J.K. Rowling", PublicationYear = 1999, CallNumber = "HP34567",
            IsAvailable = true
        },

        new Book
        {
            Id = 4, Title = "Harry Potter and the Goblet of Fire", Author = "J.K. Rowling", PublicationYear = 2000, CallNumber = "HP45678",
            IsAvailable = false
        },

        new Book
        {
            Id = 5, Title = "Harry Potter and the Order of the Phoenix", Author = "J.K. Rowling", PublicationYear = 2003, CallNumber = "HP56789",
            IsAvailable = true
        },

        new Book
        {
            Id = 6, Title = "Harry Potter and the Half-Blood Prince", Author = "J.K. Rowling", PublicationYear = 2005, CallNumber = "HP67890",
            IsAvailable = false
        },

        new Book
        {
            Id = 7, Title = "Harry Potter and the Deathly Hallows", Author = "J.K. Rowling", PublicationYear = 2007, CallNumber = "HP78901",
            IsAvailable = true
        }
    ];
}