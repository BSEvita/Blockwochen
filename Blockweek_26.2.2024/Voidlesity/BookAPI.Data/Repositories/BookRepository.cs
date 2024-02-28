using BookAPI.Data.Database;
using BookAPI.Data.Interface;
using BookAPI.Data.Models;

namespace BookAPI.Data.Repositories;

public class BookRepository : IBookRepository
{
    private readonly BookContext _context;

    public BookRepository(BookContext context)
    {
        _context = context;
    }

    public List<Book> GetAllBooks()
    {
        return _context.books.ToList();
    }

    public Book GetBook(int id)
    {
        return _context.books.FirstOrDefault(b => b.Id == id) ?? new Book();
    }
}