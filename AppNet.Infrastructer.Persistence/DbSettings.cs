using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence
{
    public class DbSettings
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private string conStr;

        public string ConStr
        {
            get { return $"Server={Server};Database={Database};User Id={Username};Password={Password}"; }

        }
        public void Save()
        {
            var json = JsonSerializer.Serialize(this);
            File.WriteAllText("dbsettings.txt", json);

        }

        public static DbSettings Load()
        {
            if (File.Exists("dbsettings.txt"))
            {
                var json = File.ReadAllText("dbsettings.txt");
                return JsonSerializer.Deserialize<DbSettings>(json);

            }

            File.WriteAllText("dbsettings.txt", "{}");
            return null;


        }
    }
}