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
using static MudBlazor.CategoryTypes;

namespace MoviesVerse.Client.Shared
{
    public partial class Carousel
    {
        //MudBlazor Carousel control properties
        private bool arrows = false;
        private bool bullets = false;
        private bool enableSwipeGesture = true;
        private bool autocycle = true;
        private Transition transition = Transition.Fade;

        [Inject] IMovieRepository? repository { get; set; }
        public List<Movie>? _slider { get; set; }

        private const string imageUrl = "https://image.tmdb.org/t/p/w1280/";
        protected override async Task OnInitializedAsync()
        {
            if (repository is object)
                _slider = (await repository.GetUpcoming()).ToList();
        }

    }
}