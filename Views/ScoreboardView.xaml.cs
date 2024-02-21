using PaperRockScissors_MauiGame.Services.Data;
using PaperRockScissors_MauiGame.ViewModels;

namespace PaperRockScissors_MauiGame.Views;

public partial class ScoreboardView : ContentPage
{
	public ScoreboardView(ScoreboardViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}