using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierShippingAddress { get; set; }
        public DateTime SupplierDate { get; set; }
        public DateTime SupplierModifitedDate { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Stock> Stock { get; set; }
        public ICollection<Report> Reports { get; set; }
    }
}
