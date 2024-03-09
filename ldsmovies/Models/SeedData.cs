using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LDSMovies.Data;
using System;
using System.Linq;
using MvcMovie.Models;

namespace LDSMovies.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new LDSMoviesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<LDSMoviesContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("2014-10-10"),
                    Genre = "Documentary",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Love, Kennedy",
                    ReleaseDate = DateTime.Parse("2017-6-2"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-6-6"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Fighting Preacher",
                    ReleaseDate = DateTime.Parse("2019-7-24"),
                    Genre = "Western",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}