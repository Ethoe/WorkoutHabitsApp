using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using WorkoutHabits.Core.Models;
using WorkoutHabits.Core.Services;
using WorkoutHabits.Helpers;

namespace WorkoutHabits.ViewModels
{
    public class ChartViewModel : Observable
    {
        public ObservableCollection<DataPoint> Source { get; } = new ObservableCollection<DataPoint>();

        public ChartViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await SampleDataService.GetChartDataAsync();
            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
