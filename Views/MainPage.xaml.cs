using PaperRockScissors_MauiGame.ViewModels;

namespace PaperRockScissors_MauiGame.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainViewModel();
            InitializeComponent();
        }
    }

}
