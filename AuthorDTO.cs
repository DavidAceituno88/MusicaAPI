namespace MusicAPI.Models
{
    public class AuthorDTO
    {
        public string Name { get; set; }
        public List<Song>? Songs { get; set; }
    }
}
