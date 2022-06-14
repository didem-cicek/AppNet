using AppNet.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class DataBase : BaseEntity
    {
        public int DataBaseID { get; set; }
        public string DataBaseName { get; set; }
        public string DataBaseUserName { get; set; }
        public string DataBasePassword { get; set; }
        public DateTime CreateDate=DateTime.Now;
    }
}
