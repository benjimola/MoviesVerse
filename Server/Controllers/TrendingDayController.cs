using Microsoft.AspNetCore.Mvc;
using TMDbLib.Client;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesVerse.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrendingDayController : ControllerBase
    {
        // GET: api/<TrendingDayController>
        [HttpGet]
        public IActionResult Get()
        {
            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetTrendingMoviesAsync(TMDbLib.Objects.Trending.TimeWindow.Day).Result;
            return Ok(response.Results);
         }


    }
}
