using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Presentation.ViewModels.Common;
using EosMonitoringApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosMonitoringApp.Presentation.ViewModels
{
    public class AccountActivitiesViewModel : ViewModel
    {
        public AccountActivitiesViewModel(ILoadService<AccountActivity> service)
        {
            AccountActivitiesCollection = service.Process();
        }

        #region Properties

        #region AccountActivitiesCollection

        private ObservableCollection<AccountActivity> _accountActivitiesCollection;

        public ObservableCollection<AccountActivity> AccountActivitiesCollection
        {
            get => _accountActivitiesCollection;
            set => Set(ref _accountActivitiesCollection, value);
        }

        #endregion

        #endregion
    }
}
