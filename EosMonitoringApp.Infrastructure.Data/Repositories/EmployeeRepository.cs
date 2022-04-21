using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EosMonitoringApp.Infrastructure.Data.Repositories
{
    public class EmployeeRepository : IGenericRepository<Employee>
    {
        private readonly IDbContext _dbContext;
        private string _query =
            "SELECT [c1staff].id, [c1staff].name AS name, [c1department].name AS department, [c1staff].post AS post, [c1staff].deleted AS deleted " +
            "FROM [c1staff] " +
            "JOIN [c1department] ON [c1staff].departmentGUID = [c1department].id " +
            "WHERE [c1staff].deleted = 0 " +
            "ORDER BY department, name";

        public EmployeeRepository(IMiraDbContext context)
        {
            _dbContext = context;
        }

        public IQueryable<Employee> GetAll() => _dbContext.Set<Employee>().FromSqlRaw(_query);
    }
}
