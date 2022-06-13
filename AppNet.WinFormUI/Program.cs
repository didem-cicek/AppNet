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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (ErpDbContext dbContext = new ErpDbContext())
            {
                //if (!dbContext.dbName.Equals(null))
                //{ Application.Run(new Login());}
                //else 
                //{ Application.Run(new SettingsFrm());}
            }
            Application.Run(new Login());
        }
    }
}