using System.Windows.Controls;

using UebungsMomentReminder.ViewModels;

namespace UebungsMomentReminder.Views
{
    public partial class MainPage : Page
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
