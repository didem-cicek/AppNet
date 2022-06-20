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
            var settings = DbSettings.Load();
            var services = new ServiceCollection();
            ConfigureServices(services);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            services.AddScoped<SettingsFrm>();
            services.AddScoped<Login>();
            services.AddScoped<SettingsFrm>();
            services.AddScoped<MainForm>();
            services.AddScoped<SuppliersFrm>();
            services.AddScoped<ProductFrm>();
            services.AddScoped<SuppliersFrm>();
            services.AddScoped<PurchasingFrm>();
            services.AddScoped<CustomerFrm>();
            services.AddScoped<SalesFrm>();
            services.AddScoped<AddCategory>();
            services.AddScoped<AddProduct>();
            services.AddScoped<DeleteProduct>();
            services.AddScoped<DeleteCategory>();
            services.AddScoped<UpdateCategory>();
            services.AddScoped<UpdateProduct>();


            using (ServiceProvider sp = services.BuildServiceProvider()) {
                if (settings.Server==null )
                {
                    MessageBox.Show("Veri Taban�n�z mevcut de�il, l�tfen �nce veri taban�n�z� olu�turunuz!", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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