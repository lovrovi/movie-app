using movieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Responses
{
    public class MediaResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public double Rating { get; set; }
        public IEnumerable<ActorResponse> Cast { get; set; }
    }
}
