using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Interfaces
{
    /// <summary>
    /// Defines the contract for interacting with books in the data store.
    /// </summary>
    public interface IBookRepository
    {
        /// <summary>
        /// Retrieves all books from the data store.
        /// </summary>
        /// <returns>A list of all books.</returns>
        List<Book> GetAllBooks();
        /// <summary>
        /// Retrieves a specific book by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the book.</param>
        /// <returns>The requested book if found, otherwise null.</returns>

        Book GetBook(int id);
    }
}
/*
   █████████  █████                                              █████████  █████               
  ███░░░░░███░░███                                              ███░░░░░███░░███                
 ░███    ░███ ░███ █████  ██████  █████████████    ██████      ░███    ░███ ░███ █████  ██████  
 ░███████████ ░███░░███  ░░░░░███░░███░░███░░███  ░░░░░███     ░███████████ ░███░░███  ░░░░░███ 
 ░███░░░░░███ ░██████░    ███████ ░███ ░███ ░███   ███████     ░███░░░░░███ ░██████░    ███████ 
 ░███    ░███ ░███░░███  ███░░███ ░███ ░███ ░███  ███░░███     ░███    ░███ ░███░░███  ███░░███ 
 █████   █████████ █████░░█████████████░███ █████░░████████    █████   █████████ █████░░████████
░░░░░   ░░░░░░░░░ ░░░░░  ░░░░░░░░░░░░░ ░░░ ░░░░░  ░░░░░░░░    ░░░░░   ░░░░░░░░░ ░░░░░  ░░░░░░░░ 
*/