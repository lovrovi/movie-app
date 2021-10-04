using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieAPI.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
