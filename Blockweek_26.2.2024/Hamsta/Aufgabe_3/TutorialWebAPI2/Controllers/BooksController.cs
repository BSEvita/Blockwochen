// BooksController.cs

using BookStore.Data.Interface;
using BookStore.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TutorialWebAPI2.Controllers
{
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
            return Ok(_bookRepository.GetAllBooks());
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = _bookRepository.GetBook(id);
            if (book == null)
                return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> CreateBook(Book book)
        {
            _bookRepository.AddBook(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book book)
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
}
