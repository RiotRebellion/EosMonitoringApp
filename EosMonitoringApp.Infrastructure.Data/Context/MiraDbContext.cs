using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EosMonitoringApp.Infrastructure.Data.Context
{
    //TODO: Recode to ADO.NET

    public class MiraDbContext : DbContext, IMiraDbContext
    {
        public MiraDbContext(DbContextOptions options)
            : base (options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasNoKey();
        }
    }
}
