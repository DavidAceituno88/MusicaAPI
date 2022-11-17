namespace MusicAPI.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
    }
}
