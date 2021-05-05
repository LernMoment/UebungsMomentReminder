using System.Windows.Controls;

using UebungsMomentReminder.ViewModels;

namespace UebungsMomentReminder.Views
{
    public partial class LernMailsSubscriberPage : Page
    {
        public LernMailsSubscriberPage(LernMailsSubscriberViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
