using System.Collections.Generic;
using BookStore.Data.Models;

namespace BookStore.Data.Interface
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBook(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}