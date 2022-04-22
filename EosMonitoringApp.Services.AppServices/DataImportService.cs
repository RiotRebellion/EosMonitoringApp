using EosMonitoringApp.Domain.Entities.Common;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Services.Interfaces;
using System.Collections.ObjectModel;

namespace EosMonitoringApp.Services.AppServices
{
    public class DataImportService<T> : IDataImportService<T> where T: IEntity
    {
        private readonly IGenericRepository<T> _repository;

        public DataImportService(IGenericRepository<T> Repository)
        {
            _repository = Repository;
        }

        public IEnumerable<T> ImportFromDatabase()
        {
            return _repository.GetAll();
        }

        public IEnumerable<T> ImportFromXML()
        {
            throw new NotImplementedException();
        }
    }
}
