using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PaperRockScissors_MauiGame.Views;
using PaperRockScissors_MauiGame.Services.Interfaces;
using PaperRockScissors_MauiGame.Services.Data;

namespace PaperRockScissors_MauiGame.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        private readonly IGameManager gameManager;
        private readonly IScoreStorage scoreStorage;

        private IGameChoice playerChoice;
        private IGameChoice opponentChoice;
        private string scoreColor;

        public GameViewModel(IGameManager gameManager, IScoreStorage scoreStorage)
        {
            this.gameManager = gameManager;
            this.scoreStorage = scoreStorage;
        }

        [RelayCommand]
        public async Task Choose(string choice)
        {
            playerChoice = gameManager.SetChoice(choice);
            opponentChoice = gameManager.RandChoice();

            string score = gameManager.CheckWhoWin(playerChoice, opponentChoice);
            scoreColor = SetColor(score);

            scoreStorage.AddScore(new Models.ScoreEntry
            {
                Id = scoreStorage.GetScoreList().Count + 1,
                PlayerChoice = playerChoice.Name,
                OpponentChoice = opponentChoice.Name,
                Score = score
            });

            await ResultRedirect(score);
        }

        private string SetColor(string score)
        {
            return score switch
            {
                "Win" => "Green",
                "Draw" => "Orange",
                "Loose" => "Red",
                _ => "Black"
            };
        }

        private async Task ResultRedirect(string score) => await Shell.Current.GoToAsync($"{nameof(ResultView)}?score={score}&playerChoice={playerChoice.Name.ToLower()}.png&opponentChoice={opponentChoice.Name.ToLower()}.png&color={scoreColor}");

        [RelayCommand]
        public async Task Cancel() => await Shell.Current.GoToAsync("MainView");
    }
}
