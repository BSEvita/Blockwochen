using BookStoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreMVC.Data
{
    public class DatabaseInitializerService
    {
        private readonly BookContext context;

        public DatabaseInitializerService(BookContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            InitializeBooksInDatabase();
        }

        public void InitializeBooksInDatabase()
        {
            foreach (Books newBook in BookList)
            {
                context.Book.Add(newBook);
            }

            context.SaveChanges();
        }

        private readonly List<Books> BookList =
        [
            new Books { Id = 1, Title = "Test 1", Author = "TestAuthor 1", PublicationYear = 2020, CallNumber = "12345678", IsAvailable = true },
            new Books { Id = 2, Title = "Test 2", Author = "TestAuthor 2", PublicationYear = 1999, CallNumber = "12345678", IsAvailable = false },
            new Books { Id = 3, Title = "Test 3", Author = "TestAuthor 3", PublicationYear = 5555, CallNumber = "12345678", IsAvailable = false },
            new Books { Id = 4, Title = "Test 4", Author = "TestAuthor 4", PublicationYear = 2023, CallNumber = "12345678", IsAvailable = true },
            new Books { Id = 5, Title = "Test 5", Author = "TestAuthor 5", PublicationYear = 1567, CallNumber = "12345678", IsAvailable = false },
            new Books { Id = 6, Title = "Test 6", Author = "TestAuthor 6", PublicationYear = 1998, CallNumber = "12345678", IsAvailable = false },
            new Books { Id = 7, Title = "Test 7", Author = "TestAuthor 7", PublicationYear = 1979, CallNumber = "12345678", IsAvailable = true },
            new Books { Id = 8, Title = "Test 8", Author = "TestAuthor 8", PublicationYear = 1966, CallNumber = "12345678", IsAvailable = false },
            new Books { Id = 9, Title = "Test 9", Author = "TestAuthor 9", PublicationYear = 2015, CallNumber = "12345678", IsAvailable = true }
        ];
    }
}
