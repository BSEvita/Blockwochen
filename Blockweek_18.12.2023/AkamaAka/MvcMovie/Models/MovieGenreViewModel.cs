using Microsoft.AspNetCore.Mvc.Rendering; // This namespace contains classes for rendering HTML elements in ASP.NET MVC applications.
using System.Collections.Generic; // This namespace provides generic collection classes, such as `List<T>`.

namespace MvcMovie.Models // This namespace is used to organize the `MovieGenreViewModel` class.
{
    public class MovieGenreViewModel
    {
        /// <summary>
        /// Gets or sets a list of `Movie` objects.
        /// </summary>
        public List<Movie>? Movies { get; set; } // This property holds a list of `Movie` objects representing the movies to be displayed.

        /// <summary>
        /// Gets or sets a `SelectList` object containing the list of available genres.
        /// </summary>
        public SelectList? Genres { get; set; } // This property holds a `SelectList` object, which is used to display a list of genres in a select input element.

        /// <summary>
        /// Gets or sets the selected genre.
        /// </summary>
        public string? MovieGenre { get; set; } // This property indicates the currently selected genre from the available genres.

        /// <summary>
        /// Gets or sets the search string.
        /// </summary>
        public string? SearchString { get; set; } // This property holds the search string entered by the user, used to filter the movies based on title.
    }
}