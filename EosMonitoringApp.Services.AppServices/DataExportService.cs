using EosMonitoringApp.Domain.Entities.Common;
using EosMonitoringApp.Services.Interfaces;
using System.Collections;

namespace EosMonitoringApp.Services.AppServices
{
    public class DataExportService<T> : IDataExportService<T> where T: IEntity
    {
        public void ExportToXML(IEnumerable<T> enumirable)
        {
            
        }
    }
}
