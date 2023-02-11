using System.Net.Http.Json;
using Shared;
using TMDbLib.Objects.Movies;


namespace MoviesVerse.Client.Helpers
{
    public class MovieRepositories : IMovieRepository
    {
        readonly HttpClient Http;
        public MovieRepositories(HttpClient http)
        {
            Http = http;
        }

        public Task<IEnumerable<Movie>> GetNowPlaying()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetPopular()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetToprated()
        {
            throw new NotImplementedException();
        }

    

        public async Task<IEnumerable<Trailers>> GetTrailer(int tid)
        {
            var response = await Http.GetFromJsonAsync<Trailers[]>($"/api/Trailers/{tid}");
            if(response == null){
                throw new Exception("Something has gone wrong");
            }

            return response;
        }

        public async Task<IEnumerable<Movie>> GetTrendingMoviesDay()
        {
            var response = await Http.GetFromJsonAsync<Movie[]>($"/api/Trendingday");
            if(response == null){
                throw new Exception("Something has gone wrong");
            }

            return response;
        }

        public async Task<IEnumerable<Movie>> GetTrendingMoviesWeek()
        {
            var response = await Http.GetFromJsonAsync<Movie[]>($"/api/Trendingweek");
            if (response == null)
            {
                throw new Exception("Something has gone wrong");
            }

            return response;
        }

        public async Task<IEnumerable<Movie>> GetUpcoming()
        {
            var response = await Http.GetFromJsonAsync<Movie[]>($"/api/Carousel");
            if(response == null)
            {
                throw new Exception("Something went wrong");
            }
            return response;
        }
    }
}
