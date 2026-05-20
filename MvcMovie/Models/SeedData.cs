using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies; if the database is already seeded, do nothing.
            if (context.Movie.Any())
            {
                return;
            }

            context.Movie.AddRange(
                // --- Movies from the Microsoft tutorial ---
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Ghostbusters",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "PG"
                },

                // --- My own favorite movies (assignment requirement: at least 3) ---
                // Swap these for your actual favorites if you like.
                new Movie
                {
                    Title = "Interstellar",
                    ReleaseDate = DateTime.Parse("2014-11-7"),
                    Genre = "Science Fiction",
                    Price = 12.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Action",
                    Price = 11.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Spider Man",
                    ReleaseDate = DateTime.Parse("2021-12-17"),
                    Genre = "Action",
                    Price = 14.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Inside Out",
                    ReleaseDate = DateTime.Parse("2015-6-19"),
                    Genre = "Animation",
                    Price = 10.99M,
                    Rating = "PG"
                }
            );
            context.SaveChanges();
        }
    }
}
