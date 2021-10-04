using System;
using System.Collections.Generic;

namespace movieAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double AvgRating { get; set; }
        public IEnumerable<ActorMovie> ActorMovie { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
    }
}
