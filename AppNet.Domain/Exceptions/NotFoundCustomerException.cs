using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class NotFoundCustomerException : Exception
    {
        public NotFoundCustomerException(string customerName) : base($"{customerName} isimli müşteri bulunamadı.")
        {

        }
    }
}
