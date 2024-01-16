using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models.SeedData
{
    public static class SeedData
    {
        /// <summary>
        /// Initializes the database with sample data.
        /// </summary>
        /// <param name="serviceProvider">The service provider to access the database context.</param>
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Check if the database is already populated with movie data
                if (context.Movie.Any())
                {
                    return; // No need to populate the database if it already has data
                }

                // Add sample movie data to the database
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-02-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-03-13"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 8.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-02-23"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-04-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    }
                );
                context.SaveChanges(); // Save the changes made to the database
            }
        }
    }
}
