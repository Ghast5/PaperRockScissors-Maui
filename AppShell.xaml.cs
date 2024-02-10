using PaperRockScissors_MauiGame.Views;

namespace PaperRockScissors_MauiGame
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ResultView), typeof(ResultView));
            Routing.RegisterRoute(nameof(GameView), typeof(GameView));
            Routing.RegisterRoute("MainView", typeof(MainPage));
        }
    }
}
