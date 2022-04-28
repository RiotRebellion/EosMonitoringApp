using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace EosMonitoringApp.Infrastructure.Data.Repositories
{
    public class CabinetRepository : IGenericRepository<Cabinet>
    {
        private readonly IDeloDbContext _dbContext;
        private readonly string _query =
            "SELECT E.CLASSIF_NAME AS Name, " +
            "D.CLASSIF_NAME AS Department, " +
            "DP.CLASSIF_NAME AS ParentDepartment, " +
            "CABINET_NAME AS Cabinet, " +
            "DC.CLASSIF_NAME AS CabinetDepartment " +
            "FROM DEPARTMENT E " +
            "FULL JOIN DEPARTMENT D ON E.ISN_HIGH_NODE = D.ISN_NODE " +
            "FULL JOIN DEPARTMENT DP ON D.ISN_HIGH_NODE = DP.ISN_NODE " +
            "FULL JOIN CABINET ON E.ISN_CABINET = CABINET.ISN_CABINET " +
            "FULL JOIN DEPARTMENT DC ON DC.DUE = CABINET.DUE " +
            "WHERE E.CARD_FLAG = 0 " +
                "and E.ISN_HIGH_NODE <> 0 " +
                "and E.deleted = 0 " +
                "and E.IS_NODE = 1 " +
            "UNION ALL " +
            "SELECT E.CLASSIF_NAME AS Name, " +
            "D.CLASSIF_NAME AS Department, " +
            "DP.CLASSIF_NAME AS ParentDepartment, " +
            "CABINET_NAME AS Cabinet, " +
            "DC.CLASSIF_NAME AS CabinetDepartment " +
            "FROM CABINET " +
            "FULL JOIN DEPARTMENT E ON CABINET.ISN_CABINET = E.ISN_CABINET " +
            "FULL JOIN DEPARTMENT D ON E.ISN_HIGH_NODE = D.ISN_NODE " +
            "FULL JOIN DEPARTMENT DP ON D.ISN_HIGH_NODE = DP.ISN_NODE " +
            "JOIN DEPARTMENT DC ON DC.DUE = CABINET.DUE " +
            "WHERE E.CLASSIF_NAME IS NULL " +
                "AND DC.DELETED = 0 ";

        public CabinetRepository(IDeloDbContext context)
        {
            _dbContext = context;
        }

        public IEnumerable<Cabinet> GetAll() => _dbContext.Set<Cabinet>().FromSqlRaw(_query);
    }
}
