using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Presentation.ViewModels.Common;
using EosMonitoringApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosMonitoringApp.Presentation.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel(IService<AccountActivity> service)
        {
            AccountActivities = service.Process();
        }

        #region

        private IEnumerable<AccountActivity> _accountActivities;

        public IEnumerable<AccountActivity> AccountActivities
        {
            get => _accountActivities;
            set => Set(ref _accountActivities, value);
        }

        #endregion
    }
}
