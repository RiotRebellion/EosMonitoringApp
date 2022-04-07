using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Domain.Entities.Common;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosMonitoringApp.Services.AppServices
{
    public class LoadService<T> : IService<T> where T: IEntity
    {
        private readonly IGenericRepository<T> _repository;

        public LoadService(IGenericRepository<T> Repository)
        {
            _repository = Repository;
        }

        public IEnumerable<T> Process()
        {
            IEnumerable<T> accounts = _repository.GetAll();
            return accounts;
        }
    }
}
