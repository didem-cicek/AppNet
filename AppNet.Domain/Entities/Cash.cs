using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Cash
    {
        public int CashID { get; set; }
        public int SaleID { get; set; }
        public Sale Sale { get; set; }
        public int StockID { get; set; }
        public Stock Stock { get; set; }
        public DateTime CashDate { get; set; }
        public DateTime CashModifitedDate { get; set; }
        public ICollection<Report> Reports { get; set; }
    }
}
