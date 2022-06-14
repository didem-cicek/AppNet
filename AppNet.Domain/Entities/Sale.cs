using AppNet.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Sale: BaseEntity
    {
        public int SaleID { get; set; }
        public int StockID { get; set; }
        public Stock Stock { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public short ProductPiece { get; set; }
        public decimal SalePrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string SaleDesription { get; set; }
        public string SaleStatus { get; set; }
        public DateTime SaleDate { get; set; }
        public DateTime SaleModifitedDate { get; set; }
        public string SalePaymentMethod { get; set; }
        public ICollection<Cash> Cashes { get; set; }
        public ICollection<Report> Reports { get; set; }

    }
}
