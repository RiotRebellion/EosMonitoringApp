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
    public class AccountActivityRepository : IGenericRepository<AccountActivity>
    {
        private readonly IDeloDbContext _context;
        private DbSet<AccountActivity> _dbSet;
        private readonly string query =
            "SELECT SURNAME_PATRON as FullName, MAX(DATE_TIME) as LastAccess " +
            "FROM CONNECTION_LOG " +
            "RIGHT JOIN USER_CL ON CONNECTION_LOG.DELO_USER = USER_CL.CLASSIF_NAME " +
            "WHERE DELETED LIKE 0 " +
            "AND SURNAME_PATRON LIKE '%%' " +
            "AND SURNAME_PATRON NOT LIKE '%[123456789]%' " +
            "AND SURNAME_PATRON NOT LIKE '%[b-Z]%' " +
            "GROUP BY SURNAME_PATRON " +
            "order by LastAccess desc ";

        public AccountActivityRepository(IDeloDbContext context)
        {
            _context = context;
            _dbSet = context.AccountActivities;
        }

        public IQueryable<AccountActivity> GetAll() => _dbSet.FromSqlRaw(query);
    }
}
