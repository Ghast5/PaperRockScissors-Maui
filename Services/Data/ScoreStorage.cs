using PaperRockScissors_MauiGame.Models;
using PaperRockScissors_MauiGame.Services.Interfaces;

namespace PaperRockScissors_MauiGame.Services.Data
{
    public class ScoreStorage : IScoreStorage
    {
        private List<ScoreEntry> scoreEntries = [];

        public void AddScore(ScoreEntry entry) =>  scoreEntries.Add(entry);
        public void ResetStorage() => scoreEntries.Clear();
        public List<ScoreEntry> GetScoreList() => scoreEntries;
    }
}
