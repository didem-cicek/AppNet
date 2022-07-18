using AppNet.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Customer: BaseEntity
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerShippingAddress { get; set; }
        public int CustomerTaxNumber { get; set; }
        public string CustomerTaxOffice { get; set; }
        public string CustomerDesription { get; set; }
        public decimal CustomerDebt { get; set; }
        public decimal CustomerReceivable { get; set; }
        public DateTime CustomerDate { get; set; }
        public DateTime CustomerModifitedDate { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public ICollection<Report> Reports { get; set; }

    }
}
