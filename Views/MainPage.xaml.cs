using PaperRockScissors_MauiGame.ViewModels;

namespace PaperRockScissors_MauiGame.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel viewModel)
        {
            BindingContext = viewModel;
            InitializeComponent();
        }
    }

}
