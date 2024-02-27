using BookStore.Data.Interface;
using BookStore.Data.Models;
using BookStore.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private IBookRepository bookRepository;

    public BooksController(IBookRepository bookRepository)
    {
        this.bookRepository = bookRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetAllBooks()
    {
        return bookRepository.GetAllBooks();
    }

    [HttpGet("{id}")]
    public ActionResult<Book> GetBook(int id)
    {
        var book = bookRepository.GetBook(id);
        if (book == null)
            return NotFound();
        return book;
    }
}