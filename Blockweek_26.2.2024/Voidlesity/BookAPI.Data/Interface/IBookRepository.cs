using BookAPI.Data.Models;

namespace BookAPI.Data.Interface;

public interface IBookRepository
{
    List<Book> GetAllBooks();
    Book GetBook(int id);
}