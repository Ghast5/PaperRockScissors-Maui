using PaperRockScissors_MauiGame.Services.Interfaces;

namespace PaperRockScissors_MauiGame.Models
{
    public class Scissors : IGameChoice
    {
        public string Name => "Scissors";

        public string Strong => "Paper";

        public string Weakness => "Rock";
    }
}
