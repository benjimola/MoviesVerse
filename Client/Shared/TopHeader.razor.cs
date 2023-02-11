using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using MoviesVerse.Client;
using MoviesVerse.Client.Shared;
using MudBlazor;
using MoviesVerse.Client.Pages.Components;
using TMDbLib;
using TMDbLib.Objects.Movies;
using MoviesVerse.Client.Helpers;

namespace MoviesVerse.Client.Shared
{
    public partial class TopHeader
    {
        //public List<Movie> trendingDay { get; set; }
        //[Inject] IMovieRepository repository { get; set; }


        //protected async override  Task OnInitializedAsync()
        //{
        //    trendingDay = (await repository.GetTrendingMoviesDay()).ToList();
        //}

    }
}