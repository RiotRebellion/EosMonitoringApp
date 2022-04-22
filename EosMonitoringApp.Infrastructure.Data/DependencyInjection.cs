using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Domain.Interfaces;
using EosMonitoringApp.Infrastructure.Data.Context;
using EosMonitoringApp.Infrastructure.Data.Repositories;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EosMonitoringApp.Infrastructure.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration) => services
            .AddDbContext<DeloDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("Delo")))
            .AddDbContext<MiraDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("Mira")))
            .AddTransient<IMiraDbContext>(provider => provider.GetService<MiraDbContext>())
            .AddTransient<IDeloDbContext>(provider => provider.GetService<DeloDbContext>())
            .AddRepositories();

        public static IServiceCollection AddRepositories(this IServiceCollection services) => services
            .AddTransient<IGenericRepository<Account>, AccountRepository>()
            .AddTransient<IGenericRepository<AccountActivity>, AccountActivityRepository>()
            .AddTransient<IGenericRepository<Cabinet>, CabinetRepository>()
            .AddTransient<IGenericRepository<Employee>, EmployeeRepository>();
    }
}
