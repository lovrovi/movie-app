using MovieAPI.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieAPI.Models
{
    public class Rating : BaseEntity
    {
        public int Score { get; set; }
        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}
