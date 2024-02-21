using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PaperRockScissors_MauiGame.Services.Interfaces;
using PaperRockScissors_MauiGame.Views;

namespace PaperRockScissors_MauiGame.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private IScoreStorage scoreStorage;

        public MainViewModel(IScoreStorage scoreStorage)
        {
            this.scoreStorage = scoreStorage;
            scoreStorage.ResetStorage();
        }

        [RelayCommand]
        public async Task PlayRedirect() => await Shell.Current.GoToAsync(nameof(GameView));
    }
}
