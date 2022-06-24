using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.ViewModels
{
    public class ReportViewModel
    {
        public decimal TotalSales { get; set; }
        public int TotalStock { get; set; }
        public int TotalCustomer { get; set; }
        public decimal TotalCash { get; set; }
        public string CritialStockName { get; set; }
        public int CritialStok { get; set; }
    }
}
