using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Presentation.ViewModels.Commands;
using EosMonitoringApp.Presentation.ViewModels.Common;
using EosMonitoringApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EosMonitoringApp.Presentation.ViewModels
{
    public class EmployeeChangesViewModel : ViewModel
    {
        private readonly IDataImportService<Employee> _importService;

        private IEnumerable<Employee> _nextEmployeeCollection;
        private IEnumerable<Employee> _prevEmployeeCollection;

        public EmployeeChangesViewModel(IDataImportService<Employee> importService)
        {
            _importService = importService;

            #region Registration

            #region Commands

            FetchEmployees = new RelayCommand(OnFetchEmployeesExecuted, CanFetchEmployeesExecute);

            #endregion

            #endregion
        }

        #region Properties

        #region EmployeeCollection

        private ObservableCollection<Employee> _employeeCollection;

        public ObservableCollection<Employee> EmployeeCollection
        {
            get => _employeeCollection;
            set => Set(ref _employeeCollection, value);
        }

        #endregion

        #region NextDataTime

        private string _nextDateTime;

        public string NextDataTime
        {
            get => _nextDateTime;
            set => Set(ref _nextDateTime, value);
        }

        #endregion

        #region PrevDataTime

        private string _prevDateTime;

        public string PrevDataTime
        {
            get => _prevDateTime;
            set => Set(ref _prevDateTime, value);
        }

        #endregion

        #endregion

        #region Commands

        #region MyRegion

        public ICommand FetchEmployees { get; private set; }

        private bool CanFetchEmployeesExecute(object p) => true;
        
        private void OnFetchEmployeesExecuted(object p)
        {
            EmployeeCollection = new ObservableCollection<Employee>(_importService.ImportFromDatabase());
        }

        #endregion

        #endregion
    }
}
