using AppNet.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Log :BaseEntity
    {
        public int LogID { get; set; }
        public string LogName { get; set; }

        public DateTime LogDate = DateTime.Now;
        public string LogType { get; set; }
    }
}
