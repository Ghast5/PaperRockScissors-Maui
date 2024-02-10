using PaperRockScissors_MauiGame.ViewModels;

namespace PaperRockScissors_MauiGame.Views;

public partial class GameView : ContentPage
{
	public GameView(GameViewModel gameViewModel)
	{
		BindingContext = gameViewModel;
		InitializeComponent();
	}
}