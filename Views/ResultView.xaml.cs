using PaperRockScissors_MauiGame.ViewModels;

namespace PaperRockScissors_MauiGame.Views;

public partial class ResultView : ContentPage
{
	public ResultView(ResultViewModel resultViewModel)
	{
		BindingContext = resultViewModel;
		InitializeComponent();
	}
}