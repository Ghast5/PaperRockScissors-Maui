using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PaperRockScissors_MauiGame.Views;

namespace PaperRockScissors_MauiGame.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task PlayRedirect() => await Shell.Current.GoToAsync(nameof(GameView));
    }
}
