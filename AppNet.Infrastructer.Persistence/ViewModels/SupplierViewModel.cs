using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.ViewModels
{
    public class SupplierViewModel
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierShippingAddress { get; set; }
        public decimal SupplierDebt { get; set; }
        public decimal SupplierReceivable { get; set; }
        public DateTime Date { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
