using Microsoft.UI.Xaml.Controls;

using WinUIApp.ViewModels;

namespace WinUIApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; }

        public MainPage()
        {
            ViewModel = App.GetService<MainViewModel>();
            InitializeComponent();
        }
    }
}
