using BL;
using DL;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Wpf
{
    public partial class App
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services
                // Windows
                .AddSingleton<MainWindow>()
                // DL
                .AddServicesForDL()
                // BL
                .AddServicesForBL();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();

            mainWindow.Show();
        }
    }
}