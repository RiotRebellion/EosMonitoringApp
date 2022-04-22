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
            .AddScoped<ILoadService<Account>, LoadService<Account>>()
            .AddScoped<ILoadService<AccountActivity>, LoadService<AccountActivity>>()
            .AddScoped<ILoadService<Cabinet>, LoadService<Cabinet>>()
            .AddScoped<ILoadService<Employee>, LoadService<Employee>>()
            ;
    }
}
