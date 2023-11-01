using System.Diagnostics;
using System.Windows.Input;
using Testing_September.Core;

namespace Testing_September.MVVM.ViewModel
{

    internal class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand PhishingViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public PhishingViewModel PhishingVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            PhishingVM = new PhishingViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            PhishingViewCommand = new RelayCommand(o =>
            {
                CurrentView = PhishingVM;
            });
        }


    }
}
