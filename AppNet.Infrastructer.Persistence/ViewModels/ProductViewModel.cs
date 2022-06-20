using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategorName { get; set; }
        public DateTime Time { get; set; }
        public DateTime ModifitedDate { get; set; }
    }
}
