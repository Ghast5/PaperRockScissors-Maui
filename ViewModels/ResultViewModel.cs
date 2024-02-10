using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PaperRockScissors_MauiGame.Views;

namespace PaperRockScissors_MauiGame.ViewModels
{
    [QueryProperty(nameof(Score), "score")]
    public partial class ResultViewModel : ObservableObject
    {
        [ObservableProperty]
        private string score;

        [RelayCommand]
        public async Task PlayAgain() => await Shell.Current.GoToAsync(nameof(GameView));

        [RelayCommand]
        public async Task Exit() => await Shell.Current.GoToAsync("MainView");
    }
}
