using Microsoft.EntityFrameworkCore;
using movieAPI.Data;
using movieAPI.Models;
using MovieAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace MovieAPI.Services
{
    public class MovieService : IMovieService
    {
        private readonly AppDbContext _context;
        public MovieService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MovieResponse>> GetMovies(string search, int num)
        {
            search = HttpUtility.UrlDecode(search);

            List<string> greaterComparison = new()
            {
                "at least",
                "more than",
                "greater than",
                "younger than",
                "after"
            };
            List<string> lesserComparison = new()
            {
                "at most",
                "less than",
                "fewer than",
                "older than",
                "before"
            };
            string operation = "=";
            
            if (!string.IsNullOrEmpty(search) && lesserComparison.Any(x => search.Contains(x)))
            {
                operation = "<";
            }
            else if (!string.IsNullOrEmpty(search) && greaterComparison.Any(x => search.Contains(x)))
            {
                operation = ">";
            }

            var movies = await _context.Movies.Include(x => x.ActorMovie).ThenInclude(x => x.Actor).Where(Filter(search, operation)).OrderByDescending(x => x.AvgRating).Take(num).ToListAsync();

            var mappedMovies = movies.Select(x => new MovieResponse
            {
                Rating = x.AvgRating,
                Image = x.Image,
                Description = x.Description,
                ReleaseDate = x.ReleaseDate,
                Title = x.Title,
                Cast = x.ActorMovie.Select(x => new ActorResponse { Name = x.Actor.Name })
            });
            return mappedMovies.OrderByDescending(x => x.Rating);
        }

        private static Expression<Func<Movie, bool>> Filter(string search, string operation)
        {
            search = search?.Trim().ToLower();
            var numInSearch = new string(search?.Where(char.IsDigit).ToArray());
            double.TryParse(numInSearch, out double num);

            return x => string.IsNullOrEmpty(search)
            || ((search.Contains("stars") && num >= 1 && ((operation.Equals("<") && x.AvgRating <= num) || (operation.Equals(">") && x.AvgRating >= num) || (operation.Equals("=") && x.AvgRating == num)))
            || (search.Contains("years") && num >= 1 && ((operation.Equals("<") && x.ReleaseDate.Year < DateTime.Now.Year - num) || (operation.Equals(">") && x.ReleaseDate.Year > DateTime.Now.Year - num)))
            || (num >= 1000 && ((operation.Equals("<") && x.ReleaseDate.Year < num) || (operation.Equals(">") && x.ReleaseDate.Year > num)))
            || (x.Description.Contains(search) || x.ReleaseDate.Year == num || x.Title.ToLower().Contains(search))
            );
        }
    }
}
