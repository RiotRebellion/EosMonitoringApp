using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Domain.Entities.Common;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosMonitoringApp.Services.AppServices
{
    public class LoadService<T> : ILoadService<T> where T: IEntity
    {
        private readonly IGenericRepository<T> _repository;

        public LoadService(IGenericRepository<T> Repository)
        {
            _repository = Repository;
        }

        public ObservableCollection<T> Process()
        {
            ObservableCollection<T> accounts = new ObservableCollection<T>(_repository.GetAll());
            return accounts;
        }
    }
}
