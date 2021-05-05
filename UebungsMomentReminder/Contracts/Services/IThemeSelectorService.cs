using System;

using UebungsMomentReminder.Models;

namespace UebungsMomentReminder.Contracts.Services
{
    public interface IThemeSelectorService
    {
        void InitializeTheme();

        void SetTheme(AppTheme theme);

        AppTheme GetCurrentTheme();
    }
}
