using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EosMonitoringApp.Infrastructure.Data.Context
{
    public class MiraDbContext : DbContext, IMiraDbContext
    {
        public MiraDbContext(DbContextOptions options)
            : base (options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
