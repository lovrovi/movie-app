namespace movieAPI.Models
{
    public class ActorMedia
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}
