using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using QuestPDF.Infrastructure;
using Recibo.Models;
using Recibo.View;
using Recibo.ViewModel;
using Recibo.Util;
using QuestPDF.Companion;

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
            QuestPDF.Settings.License = LicenseType.Community;

            var host = CreateHostBuilder().Build();

            ApplicationConfiguration.Initialize();

            Application.Run(host.Services.GetRequiredService<Home>());

            ReciboProvisorio reciboProvisorio = new();
            ReciboProvisorioPdfDocument _reciboProvisorioPdfDocument = new(reciboProvisorio);
            _reciboProvisorioPdfDocument.ShowInCompanion();
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                    logging.AddDebug();
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<recibos_dbContext>(options =>
                        options.UseMySql("server=localhost;port=3307;database=recibos_db;uid=root;pwd=secret", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.39-mysql")));
                    services.AddTransient<ReciboProvisorioVM>();
                    services.AddTransient<frm_EmitirReciboProvisorio>();
                    services.AddTransient<frm_RecentesReciboProvisorio>();
                    services.AddTransient<PdfService>();
                    services.AddTransient<Home>();
                });
    }
}
