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
        private readonly IDeloDbContext _context;
        private DbSet<Account> _dbSet;
        private string _query = "";

        public AccountRepository(IDeloDbContext context)
        {
            _context = context;
            _dbSet = context.Accounts;
        }

        public IQueryable<Account> GetAll() => throw new NotImplementedException();
    }
}
