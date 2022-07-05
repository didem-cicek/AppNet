using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.ViewModels
{
    public class StockAddListViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Piece { get; set; }
        public decimal Price { get; set; }
        public short CritialStock { get; set; }
    }
}
