using EosMonitoringApp.Domain.Entities.Common;
using EosMonitoringApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosMonitoringApp.Services.Interfaces
{
    public interface IService<T> where T : IEntity
    {
        IEnumerable<T> Process();
    }
}
