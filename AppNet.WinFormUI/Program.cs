using AppNet.AppService;
using AppNet.AppServices;
using AppNet.Infrastructer.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Data;
using System.Drawing;

namespace AppNet.WinFormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var service = new ServiceCollection();
            ConfigureServices(service);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var settings = DbSettings.Load();
            ApplicationConfiguration.Initialize();
            service.AddScoped<SettingsFrm>();
            service.AddScoped<Login>();
            service.AddScoped<SettingsFrm>();
            service.AddScoped<MainForm>();
            service.AddScoped<SuppliersFrm>();
            service.AddScoped<ProductFrm>();
            service.AddScoped<SuppliersFrm>();
            service.AddScoped<PurchasingFrm>();
            service.AddScoped<CustomerFrm>();
            service.AddScoped<SalesFrm>();


            using (ServiceProvider sp = service.BuildServiceProvider()) { 

                if (!File.Exists("dbsettings.txt"))
                { MessageBox.Show("Veri Taban�n�z mevcut de�il, l�tfen �nce veri taban�n�z� olu�turunuz!", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    var settingFrm = sp.GetRequiredService<SettingsFrm>();
                    Application.Run(settingFrm);
                } else {
                    var loginFrm = sp.GetRequiredService<Login>();
                    Application.Run(loginFrm);
                }
            }
        }
        public static void ConfigureServices(IServiceCollection service)
        {
            service.RegisterBusinessServices();
        }
    }
}