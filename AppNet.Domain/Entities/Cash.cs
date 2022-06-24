using AppNet.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Cash:BaseEntity
    {
        public int CashID { get; set; }
        public decimal Debt { get; set; }
        public decimal Receivable { get; set; }
        public decimal TotalCash { get; set; }
        public DateTime CashDate { get; set; }
        public DateTime CashModifitedDate { get; set; }
        public ICollection<Report> Reports { get; set; }
    }
}
