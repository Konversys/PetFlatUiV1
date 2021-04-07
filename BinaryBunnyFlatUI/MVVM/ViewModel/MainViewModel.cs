using BinaryBunnyFlatUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BinaryBunnyFlatUI.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        #region Views
        private HomeViewModel HomeVM { get; set; }
        private DiscoveryViewModel DiscoveryVM { get; set; }
        #endregion


        #region Pages toggle
        #region Команда DiscoveryView
        private ICommand mDiscoveryView;
        public ICommand DiscoveryView => mDiscoveryView ??= new RelayCommand(x => CurrentView = DiscoveryVM);
        #endregion

        #region Команда HomeView
        private ICommand mHomeView;
        public ICommand HomeView => mHomeView ??= new RelayCommand(x => CurrentView = HomeVM);
        #endregion
        #endregion

        #region Элемент IsBlackTheme
        private bool mIsBlackTheme;
        public bool IsBlackTheme
        {
            get => mIsBlackTheme;
            set 
            {
                mIsBlackTheme = value;
                OnPropertyChanged();
            }
        }
        #endregion


        #region Элемент CurrentView
        private object mCurrentView;
        public object CurrentView {
            get => mCurrentView;
            set
            {
                mCurrentView = value;
                OnPropertyChanged();
            } 
        }
        #endregion

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            CurrentView = HomeVM;
        }
    }
}
