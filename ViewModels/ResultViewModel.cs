﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PaperRockScissors_MauiGame.Views;

namespace PaperRockScissors_MauiGame.ViewModels
{
    [QueryProperty(nameof(Score), "score")]
    [QueryProperty(nameof(PlayerChoice), "playerChoice")]
    [QueryProperty(nameof(OponentChoice), "oponentChoice")]
    public partial class ResultViewModel : ObservableObject
    {

        [ObservableProperty]
        private string score;

        [ObservableProperty]
        private string playerChoice;

        [ObservableProperty]
        private string oponentChoice;

        [RelayCommand]
        public async Task PlayAgain() => await Shell.Current.GoToAsync(nameof(GameView));

        [RelayCommand]
        public async Task Exit() => await Shell.Current.GoToAsync("MainView");
    }
}
