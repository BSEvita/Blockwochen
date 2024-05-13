using Aufgabe_2.Data.Models;

namespace Aufgabe_2.Data.Interface;

public interface IBookRepository
{
    List<Book> GetAllBooks();
    Book GetBook(int id);

    void CreateBook(Book book);
    void Delete(int id);
}