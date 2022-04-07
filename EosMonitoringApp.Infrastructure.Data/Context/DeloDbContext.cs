﻿using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosMonitoringApp.Infrastructure.Data.Context
{
    public class DeloDbContext : DbContext, IDeloDbContext
    {
        public DeloDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountActivity> AccountActivities { get; set; }

        public DbSet<Cabinet> Cabinets { get; set; }
    }
}