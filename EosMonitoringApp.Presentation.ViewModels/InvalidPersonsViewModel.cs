using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Presentation.ViewModels.Common;
using EosMonitoringApp.Services.Interfaces;
using System.Collections.ObjectModel;

namespace EosMonitoringApp.Presentation.ViewModels
{
    public class InvalidPersonsViewModel : ViewModel
    {
        public InvalidPersonsViewModel(IDataImportService<InvalidPerson> service)
        {
            PersonCollection = new ObservableCollection<InvalidPerson>(service.ImportFromDatabase());
        }

        #region PersonCollection

        private ObservableCollection<InvalidPerson> _personCollection;

        public ObservableCollection<InvalidPerson> PersonCollection
        {
            get => _personCollection;
            set => Set(ref _personCollection, value);
        }
        
        #endregion
    }
}
