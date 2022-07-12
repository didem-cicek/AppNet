using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class CannotBeBlankProductException : Exception
    {
        public CannotBeBlankProductException(string blankField) : base($"{blankField} ürün alanı boş, lütfen öncelikle ürün ekleyiniz. Ürün eklemeden işlem yapamazsınız!")
        {

        }
    }
}
