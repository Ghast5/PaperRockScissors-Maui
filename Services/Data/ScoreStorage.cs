using PaperRockScissors_MauiGame.Models;

namespace PaperRockScissors_MauiGame.Services.Data
{
    public class ScoreStorage
    {
        private List<ScoreEntry> scoreEntries = [];

        public void AddScore(ScoreEntry entry) =>  scoreEntries.Add(entry);
        public List<ScoreEntry> GetScoreList() => scoreEntries;
    }
}
