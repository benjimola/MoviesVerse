using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMDbLib.Client;

namespace MoviesVerse.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrendingWeekController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {           
             TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
             var response = client.GetTrendingMoviesAsync(TMDbLib.Objects.Trending.TimeWindow.Week).Result;
             return Ok(response.Results);
        }
    }
}
