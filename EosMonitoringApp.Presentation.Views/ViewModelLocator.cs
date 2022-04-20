using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EosMonitoringApp.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace EosMonitoringApp.Presentation.Views
{
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel => App.Services.GetRequiredService<MainWindowViewModel>();
        public HomeViewModel HomeViewModel => App.Services.GetRequiredService<HomeViewModel>();
        public AccountActivitiesViewModel AccountActivityViewModel => App.Services.GetRequiredService<AccountActivitiesViewModel>();
        public AccountAttachmentsViewModel AccountAttachmentsViewModel => App.Services.GetRequiredService<AccountAttachmentsViewModel>();
        public CabinetAttachmentsViewModel CabinetAttachmentsViewModel => App.Services.GetRequiredService<CabinetAttachmentsViewModel>();
        public EmployeeChangesViewModel EmployeeChangesViewModel => App.Services.GetRequiredService<EmployeeChangesViewModel>();
        public DeletedPersonsViewModel DeletedPersonsViewModel => App.Services.GetRequiredService<DeletedPersonsViewModel>();
    }
}
