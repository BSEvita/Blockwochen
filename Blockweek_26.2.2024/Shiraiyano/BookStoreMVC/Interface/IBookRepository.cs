using BookStoreMVC.Models;

namespace BookStoreMVC.Interface
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBook(int id);
    }
}
