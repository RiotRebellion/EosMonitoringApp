using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosMonitoringApp.Infrastructure.Data.Context
{
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
