using BookStore.Data.Database;
using BookStore.Data.Interface;
using BookStore.Data.Models;

namespace BookStore.Data.Repositories;

public class BookRepository : IBookRepository
{
    private readonly BookContext context;

    public BookRepository(BookContext context)
    {
        this.context = context;
    }

    public List<Book> GetAllBooks()
    {
        return context.books.ToList();
    }

    public Book GetBook(int id)
    {
        return context.books.FirstOrDefault(b => b.Id == id) ?? new Book();
    }
}