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
        public MainWindowViewModel MainWindowViewModel = App.Services.GetRequiredService<MainWindowViewModel>();
    }
}
