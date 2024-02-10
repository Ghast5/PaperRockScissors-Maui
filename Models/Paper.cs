using PaperRockScissors_MauiGame.Services.Interfaces;

namespace PaperRockScissors_MauiGame.Models
{
    public class Paper : IGameChoice
    {
        public string Name => "Paper";

        public string Strong => "Rock";

        public string Weakness => "Scissors";
    }
}
