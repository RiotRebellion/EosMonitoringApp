using EosMonitoringApp.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EosMonitoringApp.Domain.Interfaces
{
    public interface IGenericRepository<Tentity>
        where Tentity : IEntity
    {
        IQueryable<Tentity> GetAll();        
    }
}
