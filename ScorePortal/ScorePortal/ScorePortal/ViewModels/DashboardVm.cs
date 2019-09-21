using ScorePortal.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ScorePortal.ViewModel
{
    public class DashboardVm: INotifyPropertyChanged
    {
        private ObservableCollection<EventItem> _eventItems;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<EventItem> EventItems { get => _eventItems; set { _eventItems = value; OnPropertyChanged(); } }
        public DashboardVm()
        {
            EventItems = new ObservableCollection<EventItem>();
            for (int i = 0; i < 10; i++)
            {
                EventItems.Add(new EventItem { Title = "Happpy Tournament " + i.ToString(), BackgroundImage = "game" });
            }
        }
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
