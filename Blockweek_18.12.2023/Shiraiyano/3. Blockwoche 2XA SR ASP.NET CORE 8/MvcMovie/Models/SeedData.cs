using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Matrix",
                    ReleaseDate = DateTime.Parse("1999-3-31"),
                    Genre = "Science Fiction, Action",
                    Rating = "R",
                    ProductionCost = 63000000
                },
                new Movie
                {
                    Title = "The Matrix Reloaded",
                    ReleaseDate = DateTime.Parse("2003-5-15"),
                    Genre = "Science Fiction, Action",
                    Rating = "R",
                    ProductionCost = 130000000
                },
                new Movie
                {
                    Title = "The Matrix Revolutions",
                    ReleaseDate = DateTime.Parse("2003-11-5"),
                    Genre = "Science Fiction, Action",
                    Rating = "R",
                    ProductionCost = 130000000
                },
                new Movie
                {
                    Title = "The Matrix Resurrections",
                    ReleaseDate = DateTime.Parse("2021-12-22"),
                    Genre = "Science Fiction, Action",
                    Rating = "R",
                    ProductionCost = 190000000
                }
            );
            context.SaveChanges();
        }
    }
}