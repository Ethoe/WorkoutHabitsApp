using System;

using Windows.UI.Xaml.Controls;

using WorkoutHabits.ViewModels;

namespace WorkoutHabits.Views
{
    public sealed partial class LogPage : Page
    {
        public LogViewModel ViewModel { get; } = new LogViewModel();

        public LogPage()
        {
            InitializeComponent();
        }
    }
}
