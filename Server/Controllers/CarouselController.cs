using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMDbLib.Client;

namespace MoviesVerse.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarouselController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            TMDbClient client = new TMDbClient("0bc767296e945f7da4297394b9b7fd92");
            var response = client.GetMovieUpcomingListAsync(null, 0, null, default).Result;
            return Ok(response.Results);
        }
    }
}
