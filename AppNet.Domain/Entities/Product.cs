using AppNet.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities
{
    public class Product: BaseEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDesriciption { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public DateTime ProductDate { get; set; }
        public DateTime ProductModifitedDate { get; set; }
        public ICollection<Stock> Stocks { get; set; }

    }
}
