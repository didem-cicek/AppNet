using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class AlreadyHaveProductException : Exception
    {
        public AlreadyHaveProductException(string productName) : base($"{productName} isimli bir ürün zaten kayıtlı.")
        {

        }
    }
}
