using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Presentation.ViewModels.Common;
using EosMonitoringApp.Services.Interfaces;
using System;
using System.Collections.ObjectModel;

namespace EosMonitoringApp.Presentation.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel(ILoadService<AccountActivity> service)
        {
            var temp = service.Process();
            _accountActivities = temp;
        }

        #region AccountActivities

        private ObservableCollection<AccountActivity> _accountActivities;

        public ObservableCollection<AccountActivity> AccountActivities
        {
            get => _accountActivities;
            set => Set(ref _accountActivities, value);
        }

        #endregion

        #region



        #endregion

    }
}
