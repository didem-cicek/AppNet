using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class AlreadyHaveSupplierException : Exception
    {
        public AlreadyHaveSupplierException(string supplierName) : base($"{supplierName} isimli bir tedarikçi zaten kayıtlı.")
        {

        }
    }
}
