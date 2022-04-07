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
    public class EmployeeRepository : IGenericRepository<Employee>
    {
        private readonly IMiraDbContext _context;
        private DbSet<Employee> _dbSet;
        private string _query;

        public EmployeeRepository(IMiraDbContext context)
        {
            _context = context;
            _dbSet = context.Employees;
        }

        public IQueryable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
