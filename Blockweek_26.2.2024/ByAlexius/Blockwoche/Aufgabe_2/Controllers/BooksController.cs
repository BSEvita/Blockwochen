using Aufgabe_2.Data.Interface;
using Aufgabe_2.Data.Models;
using Aufgabe_2.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aufgabe_2;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private IBookRepository _bookRepository;
     
     public BooksController(IBookRepository bookRepository)
     {
         _bookRepository = bookRepository;
     }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetAllBooks()
    {
        return _bookRepository.GetAllBooks();
    }

    [HttpGet("{id}")]
    public ActionResult<Book> GetBook(int id)
    {
        var book = _bookRepository.GetBook(id);
        if (book == null)
            return NotFound();
        return book;
    }
}