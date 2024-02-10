using PaperRockScissors_MauiGame.Models;
using PaperRockScissors_MauiGame.Services.Interfaces;

namespace PaperRockScissors_MauiGame.Services
{
    public class GameManager : IGameManager
    {
        public string CheckWhoWin(IGameChoice player, IGameChoice oponent)
        {
            if (player.Name == oponent.Name)
                return "Draw";
            else if (player.Strong == oponent.Name)
                return "Win";
            else
                return "Loose";
        }

        public IGameChoice SetChoice(string choice)
        {
            return choice switch
            {
                "Paper" => new Paper(),
                "Rock" => new Rock(),
                "Scissors" => new Scissors(),
                _ => throw new NotImplementedException(),
            };
        }

        public IGameChoice RandChoice()
        {
            string[] choices = ["Paper", "Rock", "Scissors"];
            Random rnd = new();

            rnd.Shuffle(choices);

            int randomChoice = rnd.Next(choices.Length);

            return SetChoice(choices[randomChoice]);
        }
    }
}
