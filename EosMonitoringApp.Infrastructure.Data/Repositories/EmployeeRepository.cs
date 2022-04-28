using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EosMonitoringApp.Infrastructure.Data.Repositories
{
    public class EmployeeRepository : IGenericRepository<Employee>
    {
        private readonly IMiraDbContext _dbContext;
        private string _query =
            "SELECT c1staff.name AS Name," +
            "c1department.name AS Department, " +
            "c1staff.post AS Post, " +
            "c1staff.deleted AS Status " +
            "FROM c1staff " +
            "JOIN c1department ON c1staff.departmentGUID = c1department.id " +
            "WHERE c1staff.deleted = 0 " +
            "ORDER BY Department, Name";


        public EmployeeRepository(IMiraDbContext context)
        {
            _dbContext = context;
        }

        public IEnumerable<Employee> GetAll() => _dbContext.Set<Employee>().FromSqlRaw(_query);
    }
}
