using movieAPI.Data;
using movieAPI.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public class RatingService : IRatingService
    {
        private readonly AppDbContext _context;
        public RatingService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> PostRating(int rating, int mediaId)
        {
            var mappedRating = new Rating
            {
                Score = rating,
                MediaId = mediaId
            };
            _context.Ratings.Add(mappedRating);

            double count = _context.Ratings.Where(x => x.MediaId == mediaId).Count();
            double sum = _context.Ratings.Where(x => x.MediaId == mediaId).Sum(x => x.Score);
            double avgRating = (sum + rating) / (count + 1);

            var media = _context.Medias.Where(x => x.Id == mediaId).FirstOrDefault();
            if (media == null)
            {
                return false;
            }
            media.AvgRating = avgRating;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
