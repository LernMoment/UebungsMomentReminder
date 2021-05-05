﻿using System.Windows.Controls;

using MahApps.Metro.Controls;

using UebungsMomentReminder.Contracts.Views;
using UebungsMomentReminder.ViewModels;

namespace UebungsMomentReminder.Views
{
    public partial class ShellWindow : MetroWindow, IShellWindow
    {
        public ShellWindow(ShellViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        public Frame GetNavigationFrame()
            => shellFrame;

        public void ShowWindow()
            => Show();

        public void CloseWindow()
            => Close();
    }
}
