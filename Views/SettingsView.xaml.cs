using PaperRockScissors_MauiGame.ViewModels;

namespace PaperRockScissors_MauiGame.Views;

public partial class SettingsView : ContentPage
{
	public SettingsView(SettingsViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}