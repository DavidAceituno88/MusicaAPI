using Microsoft.EntityFrameworkCore;

namespace MusicAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>().
                HasData(
                new Author { AuthorId = 1, Name = "Jose"},
                new Author { AuthorId = 2, Name = "David"},
                new Author { AuthorId = 3, Name = "Lancer" }
                );

            modelBuilder.Entity<Song>().
                HasData(
                new Song { SongId = 1, Name = "Song 1", AuthorId = 1 },
                new Song { SongId = 2, Name = "Song 2", AuthorId = 1 },
                new Song { SongId = 3, Name = "Song 3", AuthorId = 1 },
                new Song { SongId = 4, Name = "Song 1.1", AuthorId = 2 },
                new Song { SongId = 5, Name = "Song 1.2", AuthorId = 2 },
                new Song { SongId = 6, Name = "Song 1.3", AuthorId = 2 },
                new Song { SongId = 7, Name = "Song 2.1", AuthorId = 3 },
                new Song { SongId = 8, Name = "Song 2.2", AuthorId = 3 },
                new Song { SongId = 9, Name = "Song 2.3", AuthorId = 3 }
                );
        }
    }
}
