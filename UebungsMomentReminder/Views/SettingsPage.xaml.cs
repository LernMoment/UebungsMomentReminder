using System.Windows.Controls;

using UebungsMomentReminder.ViewModels;

namespace UebungsMomentReminder.Views
{
    public partial class SettingsPage : Page
    {
        public SettingsPage(SettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
