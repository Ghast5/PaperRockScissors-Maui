
namespace PaperRockScissors_MauiGame.Services.Interfaces
{
    public interface IGameManager
    {
        string CheckWhoWin(IGameChoice player, IGameChoice oponent);
        IGameChoice SetChoice(string choice);
        IGameChoice RandChoice();
    }
}
