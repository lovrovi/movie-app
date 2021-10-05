using movieAPI.Models;
using MovieAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public interface IMediaService
    {
        Task<IEnumerable<MediaResponse>> GetMedias(string search, int num, int mediaType);
    }
}
