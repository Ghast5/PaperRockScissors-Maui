using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PaperRockScissors_MauiGame.Views;
using PaperRockScissors_MauiGame.Services.Interfaces;

namespace PaperRockScissors_MauiGame.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        private readonly IGameManager gameManager;
        private IGameChoice playerChoice;
        private IGameChoice oponentChoice;

        public GameViewModel(IGameManager gameManager)
        {
            this.gameManager = gameManager;
        }

        [RelayCommand]
        public async Task Choose(string choice)
        {
            playerChoice = gameManager.SetChoice(choice);
            oponentChoice = gameManager.RandChoice();

            string score = gameManager.CheckWhoWin(playerChoice, oponentChoice);

            await ResultRedirect(score);
        }

        private async Task ResultRedirect(string score) => await Shell.Current.GoToAsync($"{nameof(ResultView)}?score={score}&playerChoice={playerChoice.Name.ToLower()}.png&oponentChoice={oponentChoice.Name.ToLower()}.png");

        [RelayCommand]
        public async Task Cancel() => await Shell.Current.Navigation.PopModalAsync();
    }
}
