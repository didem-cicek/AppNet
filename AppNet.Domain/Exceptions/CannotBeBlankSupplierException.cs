using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class CannotBeBlankSupplierException : Exception
    {
        public CannotBeBlankSupplierException(string blankField) : base($"{blankField} tedarikçi alanı boş, lütfen öncelikle tedarikçi ekleyiniz. Tedarikçi eklemeden işlem yapamazsınız!")
        {

        }
    }
}
