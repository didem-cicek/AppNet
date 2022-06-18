using AppNet.AppServices;
using AppNet.Infrastructer.Persistence;
using Microsoft.Data.SqlClient;
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
            
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ApplicationServiceSettings.RegisterAllService();

            ErpDbContext database = new ErpDbContext();

            if (database.Database.EnsureCreated()==false)
            {
                MessageBox.Show("Veri Taban�n�z mevcut de�il, l�tfen �nce veri taban�n�z� olu�turunuz!", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SettingsFrm settingsFrm = new SettingsFrm();
                settingsFrm.ShowDialog();
            }
            else {
                Application.Run(new Login());
            }
}
}
}