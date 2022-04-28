using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EosMonitoringApp.Infrastructure.Data.Repositories
{
    public class InvalidPersonRepository : IGenericRepository<InvalidPerson>
    {
        private readonly IDeloDbContext _dbContext;
        private readonly string _query = 
            "USE DELO_DB " +
            "SELECT SURNAME_PATRON as Name " +
	        "FROM USER_CL AS U " +
		    "JOIN DEPARTMENT AS D " +
		    "ON U.DUE_DEP = D.DUE " + 
	        "WHERE U.DELETED = 0 " +
		    "AND D.DELETED = 1";

        public InvalidPersonRepository(IDeloDbContext context)
        {
            _dbContext = context;
        }

        public IEnumerable<InvalidPerson> GetAll() => _dbContext.Set<InvalidPerson>().FromSqlRaw(_query);
    }
}
