using EosMonitoringApp.Domain.Entities.Common;
using System.Collections.ObjectModel;

namespace EosMonitoringApp.Services.Interfaces
{
    public interface IDataImportService<T> where T : IEntity
    {
        IEnumerable<T> ImportFromDatabase();

        IEnumerable<T> ImportFromXML();
    }
}
