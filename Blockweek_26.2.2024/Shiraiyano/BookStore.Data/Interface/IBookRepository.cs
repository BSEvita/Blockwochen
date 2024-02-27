using BookStore.Data.Models;

namespace BookStore.Data.Interface;

public interface IBookRepository
{
    List<Book> GetAllBooks();
    Book GetBook(int id);
}