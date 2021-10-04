using movieAPI.Models;
using MovieAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieResponse>> GetMovies(string search, int num);
    }
}
