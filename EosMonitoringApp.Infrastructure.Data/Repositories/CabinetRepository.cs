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
    public class CabinetRepository : IGenericRepository<Cabinet>
    {
        private readonly IDeloDbContext _context;
        private DbSet<Cabinet> _dbSet;
        private string _query;

        public CabinetRepository(IDeloDbContext context)
        {
            _context = context;
            _dbSet = context.Cabinets;
        }

        public IQueryable<Cabinet> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
