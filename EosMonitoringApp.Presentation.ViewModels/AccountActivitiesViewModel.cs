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
        private IDataImportService<AccountActivity> _service;

        public AccountActivitiesViewModel(IDataImportService<AccountActivity> service)
        {
            _service = service;
            AccountActivityCollection = new ObservableCollection<AccountActivity>(service.ImportFromDatabase());
        }

        #region Properties

        #region AccountActivityCollection

        private ObservableCollection<AccountActivity> _accountActivityCollection;

        public ObservableCollection<AccountActivity> AccountActivityCollection
        {
            get => _accountActivityCollection;
            set => Set(ref _accountActivityCollection, value);
        }

        #endregion

        #endregion
    }
}
