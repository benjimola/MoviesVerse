using Microsoft.AspNetCore.Components;
using MoviesVerse.Client.Helpers;
using MudBlazor;
using Shared;

namespace MoviesVerse.Client.Pages.Components
{
    public partial class Trailer
    {
        private int? id { get; set; }
        private string? _buttonText { get; set; } = "Streaming";
        List<Trailers>? _trailers { get; set; }
        public string? SelectedOption { get; set; }

        [Inject] IMovieRepository? repository { get; set; }
        [Inject] IDialogService DialogService { get; set; }
        private void Reset()
        {
            SelectedOption = null;
        }

        private void SetButtonText(int id)
        {
            switch (id)
            {
                case 0:
                    _buttonText = "Streaming";
                    getTrailers(id);
                    break;
                case 1:
                    _buttonText = "On TV";
                    getTrailers(id);
                    break;
                case 2:
                    _buttonText = "For Rent";
                    getTrailers(id);
                    break;
                case 3:
                    _buttonText = "In Theaters";
                    getTrailers(id);
                    break;
            }
        }
        protected override async Task OnInitializedAsync()
        {

            if (repository is object)
                _trailers = (await repository.GetTrailer(0)).ToList();

        }

        async void getTrailers(int id)
        {

            if (repository is object)
                _trailers = (await repository.GetTrailer(id)).ToList();
            StateHasChanged();
        }

        private void OpenDialog(Trailers trailer)
        {
            var parameters = new DialogParameters();
            parameters.Add("context", trailer.key);
            var options = new DialogOptions() { CloseButton = false, MaxWidth = MaxWidth.ExtraExtraLarge };
            DialogService.Show<YoutubeDialog>(trailer.Title, parameters);
        }
    }
}