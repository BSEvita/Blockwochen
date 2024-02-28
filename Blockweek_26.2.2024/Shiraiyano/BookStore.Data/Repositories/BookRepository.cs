using BookStore.Data.Database;
using BookStore.Data.Interface;
using BookStore.Data.Models;
using System.Collections.Generic;
using System.Linq;
namespace BookStore.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;

        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBook(int id)
        {
            return _context.Books.FirstOrDefault(b => b.Id == id);
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            var existingBook = _context.Books.Find(book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.PublicationYear = book.PublicationYear;
                existingBook.IsAvailable = book.IsAvailable;
                existingBook.CallNumber = book.CallNumber;
                _context.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            var bookToDelete = _context.Books.Find(id);
            if (bookToDelete != null)
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges();
            }
        }
    }
}