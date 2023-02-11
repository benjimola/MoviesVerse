using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieVerseApi.Model;
using System.Collections.Generic;
using TMDbLib.Objects.Movies;

namespace MovieVerseApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayListController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<PlayList>>> Get(Movie Moviess)
        {
            var _movies = new List<Movie>();
            var _playlist = new List<PlayList>
            {
                new PlayList
                {
                    Name = "Action",
                    Id = 1,
                    Date = DateOnly.FromDateTime(DateTime.Now),
                    Movies = new List<Movie> { Moviess }

                }
            };
            
            return Ok(_playlist);
        }

    }
}
