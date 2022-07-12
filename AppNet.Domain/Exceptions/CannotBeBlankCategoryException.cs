using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class CannotBeBlankCategoryException : Exception
    {
        public CannotBeBlankCategoryException(string blankField) : base($"{blankField} kategori alanı boş, lütfen öncelikle kategori ekleyiniz. Kategori eklemeden ürün ekleyemezsiniz!")
        {

        }
    }
}
