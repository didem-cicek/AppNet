using AppNet.AppServices;
using AppNet.Infrastructer.Persistence;

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
            var filePath = "AppNet-Domain-Entities-DataBase" + ".txt";
            
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
            //using (ErpDbContext dbContext = new ErpDbContext())
            //{
            //    //if (!dbContext.dbName.Equals(null))
            //    //{ Application.Run(new Login());}
            //    //else 
            //    //{ Application.Run(new SettingsFrm());}
            //}
            ApplicationServiceSettings.RegisterAllService();
            var service = IOCContainer.Resolve<ILogService>();
            if (!File.Exists(filePath))
            {
                service.Create(Convert.ToInt32(1),"Veri Tabani Bulunamadi!", "Kritik Hata");
                MessageBox.Show("Veri Tabanýnýz mevcut deðil, lütfen önce veri tabanýnýzý oluþturunuz!","Bilgilendirme Mesajý",MessageBoxButtons.OK,MessageBoxIcon.Warning );
                SettingsFrm settingsFrm = new SettingsFrm();
                settingsFrm.ShowDialog();
                service.Create(Convert.ToInt32(2), "Ýlk Veri Tabani Olusturuldu!", "Bilgilendirme");
            }
            else { Application.Run(new Login());}

                }
            }
        }