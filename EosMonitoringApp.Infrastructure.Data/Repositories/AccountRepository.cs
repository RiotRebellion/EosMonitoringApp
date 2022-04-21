using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EosMonitoringApp.Infrastructure.Data.Repositories
{
    public class AccountRepository : IGenericRepository<Account>
    {
        private readonly IDbContext _dbContext;
        private readonly string _query = "";

        public AccountRepository(IDeloDbContext context)
        {
            _dbContext = context;
        }

        public IQueryable<Account> GetAll() => _dbContext.Set<Account>().FromSqlRaw(_query);
    }
}
