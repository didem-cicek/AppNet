using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class CannotBeBlankCustomerException : Exception
    {
        public CannotBeBlankCustomerException(string blankField) : base($"{blankField} müşteri alanı boş, lütfen öncelikle müşteri ekleyiniz. Müşteri eklemeden işlem yapamazsınız!")
        {

        }
    }
}
