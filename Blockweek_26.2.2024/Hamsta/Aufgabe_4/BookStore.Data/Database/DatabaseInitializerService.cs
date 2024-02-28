using BookStore.Data.Models;

namespace BookStore.Data.Database;

public class DatabaseInitializerService
{
    private readonly BookContext Context;

    public DatabaseInitializerService(BookContext context)
    {
        Context = context;
    }

    public void Initialize()
    {
        SeedBooks();
    }
    
    public void SeedBooks()
    {
        foreach (Book newBook in NewBooks)
        {
            Context.Books.Add(newBook);
        }

        Context.SaveChanges();
    }

    private readonly List<Book> NewBooks =
    [
        new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublicationYear = 1960, CallNumber = "A45678", IsAvailable = true },
        new Book { Id = 3, Title = "1984", Author = "George Orwell", PublicationYear = 1949, CallNumber = "B12345", IsAvailable = true },
        new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", PublicationYear = 1813, CallNumber = "C67890", IsAvailable = true },
        new Book { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", PublicationYear = 1951, CallNumber = "D54321", IsAvailable = true },
        new Book { Id = 6, Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", PublicationYear = 1997, CallNumber = "E13579", IsAvailable = true },
        new Book { Id = 7, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublicationYear = 1925, CallNumber = "F97531", IsAvailable = true },
        new Book { Id = 8, Title = "The Hobbit", Author = "J.R.R. Tolkien", PublicationYear = 1937, CallNumber = "G24680", IsAvailable = true },
        new Book { Id = 9, Title = "Jane Eyre", Author = "Charlotte Brontë", PublicationYear = 1847, CallNumber = "H35791", IsAvailable = true },
        new Book { Id = 10, Title = "Moby-Dick", Author = "Herman Melville", PublicationYear = 1851, CallNumber = "I23456", IsAvailable = true },
        new Book { Id = 11, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", PublicationYear = 1954, CallNumber = "J78901", IsAvailable = true }
    ];
}