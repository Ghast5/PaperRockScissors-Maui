using LocalizationResourceManager.Maui;
using PaperRockScissors_MauiGame.Services.Enums;
using PaperRockScissors_MauiGame.Services.Interfaces;
using System.Globalization;

namespace PaperRockScissors_MauiGame.Services
{
    public class CultureInfoManager : ICultureInfoManager
    {
        private readonly ILocalizationResourceManager localizationResourceManager;

        public CultureInfoManager(ILocalizationResourceManager localizationResourceManager)
        {
            this.localizationResourceManager = localizationResourceManager;
        }

        public string GetCultureInfo() => CultureInfo.GetCultureInfo(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName).ToString();
        public void SetCultureInfo(Languages culture)
        {
            localizationResourceManager.CurrentCulture = new CultureInfo(culture.ToString());
        }
    }
}
