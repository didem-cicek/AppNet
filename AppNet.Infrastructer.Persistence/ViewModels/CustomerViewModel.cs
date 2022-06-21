using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.ViewModels
{
    public class CustomerViewModel
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
        public DateTime CustomerDate { get; set; }
        public DateTime CustomerModifitedDate { get; set; }

    }
}
