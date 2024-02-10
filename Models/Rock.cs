using PaperRockScissors_MauiGame.Services.Interfaces;

namespace PaperRockScissors_MauiGame.Models
{
    public class Rock : IGameChoice
    {
        public string Name => "Rock";

        public string Strong => "Scissors";

        public string Weakness => "Paper";
    }
}
