using movieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public interface IRatingService
    {
        Task<bool> PostRating(int rating, int mediaId);
    }
}
