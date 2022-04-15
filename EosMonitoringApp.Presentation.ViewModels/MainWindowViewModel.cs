using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Presentation.ViewModels.Common;
using EosMonitoringApp.Services.Interfaces;
using System;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace EosMonitoringApp.Presentation.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel()
        {
            CurrentViewModel = new HomeViewModel();
        }

        #region Properties

        #region CurrentViewModel

        private ViewModel _currentViewModel;

        public ViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set => Set(ref _currentViewModel, value);
        }

        #endregion

        #region AccountActivities

        private ObservableCollection<AccountActivity> _accountActivities;

        public ObservableCollection<AccountActivity> AccountActivities
        {
            get => _accountActivities;
            set => Set(ref _accountActivities, value);
        }

        #endregion

        #endregion

        #region Commands

        public ICommand OpenAccountActivitiesView { get; private set; }
        
        public void OnOpenAccountActivitiesView(object p)
        {
            CurrentViewModel = new AccountActivitiesViewModel();
        }

        #endregion

    }
}
