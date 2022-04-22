using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosMonitoringApp.Infrastructure.Data.Repositories
{
    public class CabinetRepository : IGenericRepository<Cabinet>
    {
        private readonly DbSet<Cabinet> _dbSet;
        private readonly string _query =
            "";

        public CabinetRepository(IDeloDbContext context)
        {
            _dbSet = context.Set<Cabinet>();
        }

        public IEnumerable<Cabinet> GetAll() => _dbSet.FromSqlRaw(_query);
    }
}
