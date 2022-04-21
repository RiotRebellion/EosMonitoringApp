using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EosMonitoringApp.Infrastructure.Data.Repositories
{
    public class CabinetRepository : IGenericRepository<Cabinet>
    {
        private readonly IDbContext _dbContext;
        private readonly string _query =
            "";

        public CabinetRepository(IDeloDbContext context)
        {
            _dbContext = context;
        }

        public IQueryable<Cabinet> GetAll() => _dbContext.Set<Cabinet>().FromSqlRaw(_query);
    }
}
