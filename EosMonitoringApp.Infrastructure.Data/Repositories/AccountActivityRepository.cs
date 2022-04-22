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
        private readonly IDbContext dbContext;
        private readonly string query =
            "USE DELO_DB " +
            "SELECT SURNAME_PATRON as AccountName, " +
            "ISNULL(MAX(DATE_TIME),  '1900-01-01 00:00:00') as LastAutorizationDate, " +
            "ISNULL(DATEDIFF(DAY, MAX(DATE_TIME), GETDATE()), 999999) as DaysGone " +
            "FROM CONNECTION_LOG " +
            "RIGHT JOIN USER_CL ON CONNECTION_LOG.DELO_USER = USER_CL.CLASSIF_NAME " +
            "WHERE DELETED LIKE 0 " +
            "AND SURNAME_PATRON LIKE '%%' " +
            "AND SURNAME_PATRON NOT LIKE '%[123456789]%' " +
            "AND SURNAME_PATRON NOT LIKE '%[b-Z]%' " +
            "GROUP BY SURNAME_PATRON " +
            "order by LastAutorizationDate desc ";

        public AccountActivityRepository(IDeloDbContext context)
        {
            dbContext = context;
        }

        public IEnumerable<AccountActivity> GetAll() => dbContext.Set<AccountActivity>().FromSqlRaw(query);
    }
}
