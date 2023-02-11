using Shared;
using TMDbLib.Objects.Movies;

namespace MoviesVerse.Client.Helpers
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetUpcoming();
        Task<IEnumerable<Movie>> GetTrendingMoviesDay();
        Task<IEnumerable<Movie>> GetTrendingMoviesWeek();
        Task<IEnumerable<Movie>> GetPopular();
        Task<IEnumerable<Movie>> GetToprated();
        Task<IEnumerable<Movie>> GetNowPlaying();
        Task<IEnumerable<Trailers>> GetTrailer(int tid);

    }
}
