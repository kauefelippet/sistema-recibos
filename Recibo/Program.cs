using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Recibo.Models;
using Recibo.View;
using Recibo.ViewModel;

namespace Recibo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            // Ensure the application configuration is initialized
            ApplicationConfiguration.Initialize();

            // Run the application
            Application.Run(host.Services.GetRequiredService<Home>());
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                    logging.AddDebug();
                    // Add other logging providers as needed
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<recibos_dbContext>(options =>
                        options.UseMySql("server=localhost;port=3307;database=recibos_db;uid=root;pwd=secret", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.39-mysql")));
                    services.AddTransient<ReciboProvisorioVM>();
                    services.AddTransient<frm_EmitirReciboProvisorio>();
                    services.AddTransient<Home>();
                    // Register other services
                });
    }
}
