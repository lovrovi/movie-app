using Microsoft.EntityFrameworkCore;
using movieAPI.Data;
using movieAPI.Models;
using MovieAPI.Models.Enums;
using MovieAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace MovieAPI.Services
{
    public class MediaService : IMediaService
    {
        private readonly AppDbContext _context;
        public MediaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MediaResponse>> GetMedias(string search, int num, int mediaType)
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
            var medias = new List<Media>();

            if (mediaType==1)
            {
                medias = await _context.Medias.Include(x => x.ActorMedia).ThenInclude(x => x.Actor).Where(Filter(search, operation, MediaType.Movie)).OrderByDescending(x => x.AvgRating).Take(num).ToListAsync();
            }
            else if (mediaType==2)
            {
                medias = await _context.Medias.Include(x => x.ActorMedia).ThenInclude(x => x.Actor).Where(Filter(search, operation, MediaType.Show)).OrderByDescending(x => x.AvgRating).Take(num).ToListAsync();
            }
            else
            {
                return null;
            }

            var mappedMedias = medias.Select(x => new MediaResponse
            {
                Id = x.Id,
                Rating = Math.Round(x.AvgRating, 1),
                Image = x.Image,
                Description = x.Description,
                ReleaseDate = x.ReleaseDate.ToString("dd/MMM/yyyy"),
                Title = x.Title,
                Cast = x.ActorMedia.Select(x => new ActorResponse { Name = x.Actor.Name })
            });
            return mappedMedias.OrderByDescending(x => x.Rating);
        }

        private static Expression<Func<Media, bool>> Filter(string search, string operation, MediaType mediaType)
        {
            search = search?.Trim().ToLower();
            var numInSearch = new string(search?.Where(char.IsDigit).ToArray());
            double.TryParse(numInSearch, out double num);

            return x => x.MediaType.Equals(mediaType)
            && (string.IsNullOrEmpty(search)
            || ((search.Contains("stars") && num >= 1 && ((operation.Equals("<") && x.AvgRating <= num) || (operation.Equals(">") && x.AvgRating >= num) || (operation.Equals("=") && x.AvgRating == num)))
            || (search.Contains("years") && num >= 1 && ((operation.Equals("<") && x.ReleaseDate.Year < DateTime.Now.Year - num) || (operation.Equals(">") && x.ReleaseDate.Year > DateTime.Now.Year - num)))
            || (num >= 1000 && ((operation.Equals("<") && x.ReleaseDate.Year < num) || (operation.Equals(">") && x.ReleaseDate.Year > num)))
            || (x.Description.Contains(search) || x.ReleaseDate.Year == num || x.Title.ToLower().Contains(search)))
            );
        }
    }
}
