using System.Collections.Generic;
using BookStore.Data.Models;

namespace BookStore.Data.Interface
{
    public interface IBookRepository
    {
        IEnumerable<Books> GetAllBooks();
        Books GetBook(int id);
        void AddBook(Books book);
        void UpdateBook(Books book);
        void DeleteBook(int id);
    }
}