using EosMonitoringApp.Domain.Entities.Common;
using System.Collections.ObjectModel;

namespace EosMonitoringApp.Services.Interfaces
{
    public interface ILoadService<T> where T : IEntity
    {
        ObservableCollection<T> Process();
    }
}
