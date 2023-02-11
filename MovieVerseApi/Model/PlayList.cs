using TMDbLib.Objects.Movies;

namespace MovieVerseApi.Model
{
    public class PlayList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movie>? Movies { get; set; } = new List<Movie>();
        public DateOnly Date { get; set; } 
    }
}
