using BookStoreMVC.Data;
using BookStoreMVC.Interface;
using BookStoreMVC.Models;

namespace BookStoreMVC.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext context;

        public BookRepository(BookContext context)
        {
            this.context = context;
        }

        public List<Book> GetAllBooks()
        {
            return context.Book.ToList();
        }

        public Book GetBook(int id)
        {
            return context.Book.FirstOrDefault(b => b.Id == id) ?? new Book();
        }

    }
}
