using AppNet.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Notifications : BaseEntity
    {
        public int NotificationsID { get; set; }
        public string NotificationsName { get; set; }
    }
}
