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
    public class AccountRepository : IGenericRepository<Account>
    {
        private readonly DbSet<Account> _dbSet;
        private readonly string _query = "";

        public AccountRepository(IDeloDbContext context)
        {
            _dbSet = context.Set<Account>();
        }

        public IEnumerable<Account> GetAll() => _dbSet.FromSqlRaw(_query);
    }
}
