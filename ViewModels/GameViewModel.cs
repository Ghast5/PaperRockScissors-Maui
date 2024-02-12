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
        private string resultColor;

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
            resultColor = SetColor(score);

            await ResultRedirect(score);
        }

        private string SetColor(string result)
        {
            return result switch
            {
                "Win" => "Green",
                "Draw" => "Orange",
                "Loose" => "Red",
                _ => "Black"
            };
        }

        private async Task ResultRedirect(string score) => await Shell.Current.GoToAsync($"{nameof(ResultView)}?score={score}&playerChoice={playerChoice.Name.ToLower()}.png&oponentChoice={oponentChoice.Name.ToLower()}.png&color={resultColor}");

        [RelayCommand]
        public async Task Cancel() => await Shell.Current.GoToAsync("MainView");
    }
}
