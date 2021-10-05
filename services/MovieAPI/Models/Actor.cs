using MovieAPI.Models.Base;
using System.Collections.Generic;

namespace movieAPI.Models
{
    public class Actor : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<ActorMedia> ActorMedia { get; set; }
    }
}
