using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesVerse.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailersController : ControllerBase
    {


        // GET api/<TrailersController>/5
        [HttpGet("{tid:int}")]
        public IActionResult Get(int tid)
        {
            string url = "";
            if (tid == 0)
            {
                url = "https://www.themoviedb.org/remote/panel?panel=trailer_scroller&group=streaming";
            }
            else if (tid == 1)
            {
                url = "https://www.themoviedb.org/remote/panel?panel=trailer_scroller&group=on-tv";
            }
            else if (tid == 2)
            {
                url = "https://www.themoviedb.org/remote/panel?panel=trailer_scroller&group=for-rent";
            }
            else
            {
                url = "https://www.themoviedb.org/remote/panel?panel=trailer_scroller&group=in-theatres";
            }
            List<Trailers>? _trailers = new List<Trailers>();


            HttpClient client = new HttpClient();
            HtmlDocument doc = new HtmlDocument();

            var response = client.GetStringAsync(url).Result;
            doc.LoadHtml(response);
            var nodes = doc.DocumentNode.Descendants().Where(i => i.Name == "div" && i.GetAttributeValue("class", "").StartsWith("card video style_2 true"));
            foreach (var node in nodes)
            {

                string Title = node.QuerySelector(".content").QuerySelector("h2").InnerText;
                string TrailerTitle = node.QuerySelector(".content").QuerySelector("h3").InnerHtml;
                string ImgUrl = node.QuerySelector(".backdrop").Attributes["src"].Value;
                string Url = node.QuerySelector(".content").QuerySelector("a").Attributes["href"].Value;
                int Id = int.Parse(node.QuerySelector(".options").Attributes["data-id"].Value);
                string key = node.QuerySelector(".wrapper").QuerySelector("a").Attributes["data-id"].Value;

                _trailers.Add(new Trailers()
                {
                    Title = Title,
                    TrailerTitle = TrailerTitle,
                    Id = Id,
                    ImgUrl = ImgUrl,
                    Url = Url,
                    key = key
                });
            }
            return Ok(_trailers);
        }

    }    
}
