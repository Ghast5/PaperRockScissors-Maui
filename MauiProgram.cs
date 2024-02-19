using Microsoft.Extensions.Logging;
using PaperRockScissors_MauiGame.Views;
using PaperRockScissors_MauiGame.ViewModels;
using PaperRockScissors_MauiGame.Services;
using PaperRockScissors_MauiGame.Services.Interfaces;
using PaperRockScissors_MauiGame.Services.Data;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using CommunityToolkit.Maui;

namespace PaperRockScissors_MauiGame
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("fa-solid-900.ttf", "FontAwesomeSolid");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<GameView>();
            builder.Services.AddTransient<GameViewModel>();
            builder.Services.AddTransient<ResultView>();
            builder.Services.AddTransient<ResultViewModel>();
            builder.Services.AddTransient<IGameManager, GameManager>();
            builder.Services.AddTransient<SettingsView>();
            builder.Services.AddTransient<SettingsViewModel>();
            builder.Services.AddTransient<ICultureInfoManager, CultureInfoManager>();

            builder.Services.AddTransient<ScoreboardView>();
            builder.Services.AddTransient<ScoreboardViewModel>();
            builder.Services.AddSingleton<ScoreStorage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
