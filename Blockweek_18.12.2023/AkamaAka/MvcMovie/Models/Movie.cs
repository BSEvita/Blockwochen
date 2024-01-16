using System.ComponentModel; // This namespace provides classes for data binding and validation.
using System.ComponentModel.DataAnnotations; // This namespace provides data annotations for validating and formatting data.
using System.ComponentModel.DataAnnotations.Schema; // This namespace provides data annotations for database schema generation.

namespace MvcMovie.Models // This namespace is used to organize the `Movie` class.
{
    public class Movie
    {
        /// <summary>
        /// The unique ID of the movie.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the movie.
        /// </summary>
        [StringLength(60, MinimumLength = 3)] // The title must be between 3 and 60 characters long.
        [Required] // The title is required.
        public string? Title { get; set; }

        /// <summary>
        /// The release date of the movie.
        /// </summary>
        [Display(Name = "Release Date")] // Displays the property name as "Release Date" in UI controls.
        [DataType(DataType.Date)] // Data type for the property is date.
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// The genre of the movie.
        /// </summary>
        [RegularExpression(@"^[A-z]+[a-zA-Z\s]*$")] // The genre must only contain letters and spaces.
        [Required] // The genre is required.
        [StringLength(30)] // The genre must be 30 characters or less.
        public string? Genre { get; set; }

        /// <summary>
        /// The price of the movie.
        /// </summary>
        [Range(1, 100)] // The price must be between 1 and 100.
        [DataType(DataType.Currency)] // Displays the property value with currency formatting.
        [Column(TypeName = "decimal(18, 2)")] // Data type for the property is decimal with 18 digits and 2 decimal places.
        public decimal Price { get; set; }

        /// <summary>
        /// The rating of the movie.
        /// </summary>
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")] // The rating must only contain letters, numbers, apostrophes, double quotes, spaces, and hyphens.
        [StringLength(5)] // The rating must be 5 characters or less.
        public string? Rating { get; set; }
    }
}
