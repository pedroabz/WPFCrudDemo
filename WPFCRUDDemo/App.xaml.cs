using Autofac;
using Autofac.Features.ResolveAnything;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFCRUDDemo.Model;
using WPFCRUDDemo.Services;
using WPFCRUDDemo.ViewModel;

namespace WPFCRUDDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<EmployeeDbContext>(options =>
            {
                options.UseSqlite("Data Source=Employee.db");
            });
            services.AddScoped<IDataService, DataService>();
            services.AddSingleton<EmployeeViewModel>();
            services.AddSingleton<EmployeeWindow>();
            services.AddSingleton<NewCommand>();
            services.AddSingleton<DeleteCommand>();
            services.AddSingleton<EditCommand>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<EmployeeWindow>();
            mainWindow.Show();
        }


    }
}
