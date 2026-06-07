using System.Configuration;
using System.Data;
using System.Windows;
using WpfApp1.repository;
using WpfApp1.viewmodels;
using Microsoft.Extensions.DependencyInjection;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            // registering the services and viewmodels (allowing them to havea a DI)
            services.AddSingleton<ITransactionRepository, TransactionRepository>();
            services.AddSingleton<MainWindow_ViewModel>();
            services.AddSingleton<MainWindow>();
            services.AddSingleton<AddTransactionDialog_ViewModel>();
            services.AddSingleton<AddTransactionDialog>();


            _serviceProvider = services.BuildServiceProvider();

            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }

}
