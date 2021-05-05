using System;
using System.Collections.ObjectModel;
using System.Linq;

using UebungsMomentReminder.Contracts.ViewModels;
using UebungsMomentReminder.Core.Contracts.Services;
using UebungsMomentReminder.Core.Models;
using UebungsMomentReminder.Helpers;

namespace UebungsMomentReminder.ViewModels
{
    public class LernMailsSubscriberViewModel : Observable, INavigationAware
    {
        private readonly ISampleDataService _sampleDataService;
        private SampleOrder _selected;

        public SampleOrder Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

        public LernMailsSubscriberViewModel(ISampleDataService sampleDataService)
        {
            _sampleDataService = sampleDataService;
        }

        public async void OnNavigatedTo(object parameter)
        {
            SampleItems.Clear();

            var data = await _sampleDataService.GetListDetailsDataAsync();

            foreach (var item in data)
            {
                SampleItems.Add(item);
            }

            Selected = SampleItems.First();
        }

        public void OnNavigatedFrom()
        {
        }
    }
}
