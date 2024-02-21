using PaperRockScissors_MauiGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissors_MauiGame.Services.Interfaces
{
    public interface IScoreStorage
    {
        public void AddScore(ScoreEntry entry);
        public void ResetStorage();
        public List<ScoreEntry> GetScoreList();
    }
}
