using System.Collections.Generic;

namespace movieAPI.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ActorMovie> ActorMovie { get; set; }
    }
}
