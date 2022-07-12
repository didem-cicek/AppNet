using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class AlreadyHaveCustomerException : Exception
    {
        public AlreadyHaveCustomerException(string customerName) : base($"{customerName} isimli bir müşteri zaten kayıtlı.")
        {

        }
    }
}
