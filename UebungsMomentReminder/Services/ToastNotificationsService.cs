using Microsoft.Toolkit.Uwp.Notifications;

using UebungsMomentReminder.Contracts.Services;

using Windows.UI.Notifications;

namespace UebungsMomentReminder.Services
{
    public partial class ToastNotificationsService : IToastNotificationsService
    {
        public ToastNotificationsService()
        {
        }

        public void ShowToastNotification(ToastNotification toastNotification)
        {
            ToastNotificationManagerCompat.CreateToastNotifier().Show(toastNotification);
        }
    }
}
