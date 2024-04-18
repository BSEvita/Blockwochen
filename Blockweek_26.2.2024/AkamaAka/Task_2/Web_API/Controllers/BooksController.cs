using BookStore.Data.Models;
using BookStore.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    /// <summary>
    /// Provides API endpoints for managing books in the system.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private BookRepository books = new BookRepository();
        /// <summary>
        /// Retrieves all books from the data store.
        /// </summary>
        /// <returns>A list of all available books.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBooks();
        }
        /// <summary>
        /// Retrieves a specific book by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the book.</param>
        /// <returns>The requested book if found, otherwise NotFound (404) status code.</returns>

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = books.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
    }
}


/**
    █████████  █████                                              █████████  █████               
  ███░░░░░███░░███                                              ███░░░░░███░░███                
 ░███    ░███ ░███ █████  ██████  █████████████    ██████      ░███    ░███ ░███ █████  ██████  
 ░███████████ ░███░░███  ░░░░░███░░███░░███░░███  ░░░░░███     ░███████████ ░███░░███  ░░░░░███ 
 ░███░░░░░███ ░██████░    ███████ ░███ ░███ ░███   ███████     ░███░░░░░███ ░██████░    ███████ 
 ░███    ░███ ░███░░███  ███░░███ ░███ ░███ ░███  ███░░███     ░███    ░███ ░███░░███  ███░░███ 
 █████   █████████ █████░░█████████████░███ █████░░████████    █████   █████████ █████░░████████
░░░░░   ░░░░░░░░░ ░░░░░  ░░░░░░░░░░░░░ ░░░ ░░░░░  ░░░░░░░░    ░░░░░   ░░░░░░░░░ ░░░░░  ░░░░░░░░ 
 */