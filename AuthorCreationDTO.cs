namespace MusicAPI.Models
{
    public class AuthorCreationDTO
    {
        public string Name { get; set; }
        public List<Song>? Songs { get; set; }
    }
}
