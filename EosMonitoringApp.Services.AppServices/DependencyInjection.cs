using EosMonitoringApp.Domain.Entities;
using EosMonitoringApp.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosMonitoringApp.Services.AppServices
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddImportServices()
            .AddExportServices();

        private static IServiceCollection AddImportServices(this IServiceCollection services) => services
            .AddScoped<IDataImportService<Account>, DataImportService<Account>>()
            .AddScoped<IDataImportService<AccountActivity>, DataImportService<AccountActivity>>()
            .AddScoped<IDataImportService<Cabinet>, DataImportService<Cabinet>>()
            .AddScoped<IDataImportService<Employee>, DataImportService<Employee>>()
            ;

        private static IServiceCollection AddExportServices(this IServiceCollection services) => services
            .AddScoped<IDataExportService<Employee>, DataExportService<Employee>>();
    }
}
