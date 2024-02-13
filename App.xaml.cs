
using System.Globalization;

namespace PaperRockScissors_MauiGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(CultureInfo.CurrentUICulture.Name);
            MainPage = new AppShell();
        }
    }
}
