using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EosMonitoringApp.Infrastructure.Data.Context
{
    public class DeloDbContext : DbContext, IDeloDbContext
    {
        public DeloDbContext(DbContextOptions<DeloDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountActivity> AccountActivities { get; set; }

        public DbSet<Cabinet> Cabinets { get; set; }

        public DbSet<InvalidPerson> InvalidPersons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasNoKey();
            modelBuilder.Entity<AccountActivity>().HasNoKey();
            modelBuilder.Entity<Cabinet>().HasNoKey();
            modelBuilder.Entity<InvalidPerson>().HasNoKey();
        }
    }
}
