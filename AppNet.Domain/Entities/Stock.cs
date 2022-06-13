using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Stock
    {
        public int StockID { get; set; }
        public string ProductType { get; set; }
        public decimal PurchaseUnitPrice { get; set; }
        public decimal StockTotalPrice { get; set; }
        public int StockPiece { get; set; }
        public short StockCritical { get; set; }
        public DateTime StockDate { get; set; }
        public DateTime StockModifitedDate { get; set; }

        public int SupplierID;
        public Supplier Supplier { get; set; }

        public int ProductID;
        public Product Product { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public ICollection<Cash> Cashes { get; set; }
        public ICollection<Report> Reports { get; set; }


    }
}
