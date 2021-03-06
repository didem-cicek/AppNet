using AppNet.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class User: BaseEntity
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserAuthorization { get; set; }
        public DateTime UserDate { get; set; }
        public DateTime UserModifitedDate { get; set; }
    }
}
