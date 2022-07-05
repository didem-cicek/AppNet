using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.ViewModels
{
    public class StockViewModel
    {
        public int StockID { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public int StockPiece { get; set; }
        public short CritialStock { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal StockPrice { get; set; }
        public decimal StockTotalPrice { get; set; }
        public DateTime Date { get; set; }
        public DateTime ModifiedTime { get; set; }

    }
}
