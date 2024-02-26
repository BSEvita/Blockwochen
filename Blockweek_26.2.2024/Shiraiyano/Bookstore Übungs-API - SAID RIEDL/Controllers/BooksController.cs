using Bookstore_Übungs_API___SAID_RIEDL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore_Übungs_API___SAID_RIEDL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public List<Book> books = new List<Book>()
        {
            new Book(1,"The Girl on the Train", "Hawkins, Paula", 2004),
            new Book(2,"Rogue Lawyer", "Grisham, John", 2015),
            new Book(3,"After You", "Moyes, Jojo", 2015),
            new Book(4, "All the Light We Cannot See", "Doerr, Anthony", 1963)
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books;
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            Book book = books.FirstOrDefault(x => x.Id == id);
            if (book == null) 
            {
                return NotFound();
            }
            return book;
        }
    }
}
