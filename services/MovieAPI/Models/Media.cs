using MovieAPI.Models.Base;
using MovieAPI.Models.Enums;
using System;
using System.Collections.Generic;

namespace movieAPI.Models
{
    public class Media : BaseEntity
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double AvgRating { get; set; }
        public IEnumerable<ActorMedia> ActorMedia { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
        public MediaType MediaType { get; set; }
    }
}
