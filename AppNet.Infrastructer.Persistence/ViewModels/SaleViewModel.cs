using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.ViewModels
{
    public class SaleViewModel
    {
        public int SaleID { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public short Piece { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
