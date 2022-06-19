using AppNet.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Report: BaseEntity
    {
        public int ReportID { get; set; }
        public string ReportName { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public Customer Customer { get; set; }
        public int StockID { get; set; }
        public Stock Stock { get; set; }
        public int SalesID { get; set; }
        public Sale Sale { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public Supplier Supplier { get; set; }
        public int CashID { get; set; }
        public Cash Cash { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime ReportModifitedDate { get; set; }
    }
}
