using Microsoft.EntityFrameworkCore;

namespace EosMonitoringApp.Services.Interfaces
{
    public interface IDeloDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
