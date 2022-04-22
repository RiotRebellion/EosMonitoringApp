using EosMonitoringApp.Domain.Entities.Common;
using System.Collections;

namespace EosMonitoringApp.Services.Interfaces
{
    public interface IDataExportService<T> where T : IEntity
    {
        void ExportToXML(IEnumerable<T> enumirable);
    }
}
