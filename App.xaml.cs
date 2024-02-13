
using PaperRockScissors_MauiGame.Services;
using PaperRockScissors_MauiGame.Services.Interfaces;
using System.Globalization;

namespace PaperRockScissors_MauiGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CultureInfoManager cultureManager = new();
            string culture = cultureManager.GetCultureInfo();
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture(culture);
            MainPage = new AppShell();
        }
    }
}
