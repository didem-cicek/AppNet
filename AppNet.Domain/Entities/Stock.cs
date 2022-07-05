using AppNet.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Stock: BaseEntity
    {
        public int StockID { get; set; }
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public string ProductType { get; set; }
        public decimal PurchaseUnitPrice { get; set; }
        public decimal StockTotalPrice { get; set; }
        public int StockPiece { get; set; }
        public short StockCritical { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public DateTime StockDate { get; set; }
        public DateTime StockModifitedDate { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public ICollection<Report> Reports { get; set; }


    }
}
