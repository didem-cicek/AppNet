using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.ViewModels
{
    public class CashViewModel
    {
        public int CashID { get; set; }
        public decimal Debt { get; set; }
        public decimal Receivable { get; set; }
        public decimal TotalCash { get; set; }
        public DateTime Date { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
