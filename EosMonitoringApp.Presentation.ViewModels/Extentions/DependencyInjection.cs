using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace EosMonitoringApp.Presentation.ViewModels.Extentions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
            .AddSingleton<MainWindowViewModel>()
            .AddSingleton<HomeViewModel>()
            .AddSingleton<AccountActivitiesViewModel>()
            .AddSingleton<AccountAttachmentsViewModel>()
            .AddSingleton<CabinetAttachmentsViewModel>()
            .AddSingleton<EmployeeChangesViewModel>()
            .AddSingleton<InvalidPersonsViewModel>();
        
    }
}
