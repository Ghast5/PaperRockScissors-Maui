using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PaperRockScissors_MauiGame.Views;
using PaperRockScissors_MauiGame.Services.Interfaces;

namespace PaperRockScissors_MauiGame.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        private readonly IGameManager gameManager;

        public GameViewModel(IGameManager gameManager)
        {
            this.gameManager = gameManager;
        }

        [RelayCommand]
        public async Task Choose(string choice)
        {
            IGameChoice playerChoice = gameManager.SetChoice(choice);
            IGameChoice oponentChoice = gameManager.RandChoice();

            string score = gameManager.CheckWhoWin(playerChoice, oponentChoice);

            await ResultRedirect(score);
        }

        private async Task ResultRedirect(string score) => await Shell.Current.GoToAsync($"{nameof(ResultView)}?score={score}");

        [RelayCommand]
        public async Task Cancel() => await Shell.Current.Navigation.PopModalAsync();
    }
}
