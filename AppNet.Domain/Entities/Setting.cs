using AppNet.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Setting: BaseEntity
    {
        public int SettingID { get; set; }
        public string SettingName { get; set; }
        public string DataBaseName { get; set; }
    }
}
