using Microsoft.EntityFrameworkCore;

namespace EosMonitoringApp.Services.Interfaces
{
    public interface IMiraDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
