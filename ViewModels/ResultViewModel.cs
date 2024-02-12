using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PaperRockScissors_MauiGame.Views;

namespace PaperRockScissors_MauiGame.ViewModels
{
    [QueryProperty(nameof(Score), "score")]
    [QueryProperty(nameof(PlayerChoice), "playerChoice")]
    [QueryProperty(nameof(OpponentChoice), "opponentChoice")]
    [QueryProperty(nameof(ResultColor), "color")]
    public partial class ResultViewModel : ObservableObject
    {

        [ObservableProperty]
        private string score;

        [ObservableProperty]
        private string playerChoice;

        [ObservableProperty]
        private string opponentChoice;

        [ObservableProperty]
        private string resultColor;

        [RelayCommand]
        public async Task PlayAgain() => await Shell.Current.GoToAsync(nameof(GameView));

        [RelayCommand]
        public async Task Exit() => await Shell.Current.GoToAsync("MainView");
    }
}
