using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFMovies.Data;

namespace EFMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            // query database
            var dbContext = new DataContext();

            // INSERT
            var mov1 = new Movies
            {
                Title = "It Follows",
                YearReleased = 2015,
                Genre = "Horror",
                Tagline = "A young woman is followed by an unknown supernatural force after a sexual encounter.",
                Rating = 6.9m,
            };

            var mov2 = new Movies
            {
                Title = "The NeverEnding Story",
                YearReleased = 1984,
                Genre = "Adventure",
                Tagline = "A troubled boy dives into a wondrous fantasy world through the pages of a mysterious book.",
                Rating = 7.4m,
            };

            // update rating of movies released in 1988 to a 10
            var updateRating = dbContext.Movies.Where(w => w.YearReleased == 1988);
            foreach (var movieRating in updateRating)
            {
                movieRating.Rating = 10;
            }

            // delete movies titled never ending story
            var deleteMovieTitle = dbContext.Movies.Where(w => w.Title == "The NeverEnding Story");
            dbContext.Movies.RemoveRange(deleteMovieTitle);

            // find movies in horror genre

            var findHorrorGenre = dbContext.Movies.Where(w => w.Genre == "Horror");
            foreach (var horrorMovie in findHorrorGenre)
            {
                Console.WriteLine($"Title: {horrorMovie.Title}, Year Released: {horrorMovie.YearReleased}, Rating: {horrorMovie.Rating}");
            }

            dbContext.SaveChanges();

            Console.ReadLine();
        }
    }
}