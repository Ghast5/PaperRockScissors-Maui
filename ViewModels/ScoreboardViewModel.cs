using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PaperRockScissors_MauiGame.Models;
using PaperRockScissors_MauiGame.Services.Interfaces;
using System.Collections.ObjectModel;

namespace PaperRockScissors_MauiGame.ViewModels
{
    public partial class ScoreboardViewModel : ObservableObject
    {
        private readonly IScoreStorage scoreStorage;

        [ObservableProperty]
        private ObservableCollection<ScoreEntry> entries;

        public ScoreboardViewModel(IScoreStorage scoreStorage)
        {
            this.scoreStorage = scoreStorage;
            Entries = new(scoreStorage.GetScoreList());
        }

        [RelayCommand]
        public async Task LoadData() => Entries = new(scoreStorage.GetScoreList());
    }
}
