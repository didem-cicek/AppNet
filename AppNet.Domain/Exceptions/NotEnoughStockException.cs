using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class NotEnoughStockException : Exception
    {
        public NotEnoughStockException(string productName, ushort stock, ushort takeOfStock)
            : base($"{productName} adlı üründen stokta {stock} adet var. {takeOfStock} kadar mevcut değil.")
        {

        }
    }
}
