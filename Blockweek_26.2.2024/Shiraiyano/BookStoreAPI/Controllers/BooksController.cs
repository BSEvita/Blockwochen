using BookStore.Data.Interface;
using BookStore.Data.Models;
using BookStore.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers;

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
    public ActionResult<IEnumerable<Books>> GetAllBooks()
    {
        return Ok(_bookRepository.GetAllBooks());
    }

    [HttpGet("{id}")]
    public ActionResult<Books> GetBook(int id)
    {
        var book = _bookRepository.GetBook(id);
        if (book == null)
            return NotFound();
        return Ok(book);
    }

    [HttpPost]
    public ActionResult<Books> CreateBook(Books book)
    {
        _bookRepository.AddBook(book);
        return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, Books book)
    {
        if (id != book.Id)
        {
            return BadRequest();
        }

        var existingBook = _bookRepository.GetBook(id);
        if (existingBook == null)
        {
            return NotFound();
        }

        _bookRepository.UpdateBook(book);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        Console.WriteLine(id);
        var book = _bookRepository.GetBook(id);

        if (book == null)
        {
            return NotFound();
        }

        _bookRepository.DeleteBook(id);
        return NoContent();
    }
}
