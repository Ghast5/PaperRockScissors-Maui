using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PaperRockScissors_MauiGame.Services.Enums;
using PaperRockScissors_MauiGame.Services.Interfaces;

namespace PaperRockScissors_MauiGame.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty]
        private int languageIndex;
        private readonly ICultureInfoManager cultureInfoManager;

        public SettingsViewModel(ICultureInfoManager cultureInfoManager)
        {
            this.cultureInfoManager = cultureInfoManager;

            if (Enum.TryParse(cultureInfoManager.GetCultureInfo()[..2], out Languages languageIso))
                LanguageIndex = (int)languageIso;
            else
                LanguageIndex = (int)Languages.en;
                
        }

        [RelayCommand]
        public async Task Save()
        {
            await Task.Delay(100);
            cultureInfoManager.SetCultureInfo((Languages)LanguageIndex);
        }
    }
}
