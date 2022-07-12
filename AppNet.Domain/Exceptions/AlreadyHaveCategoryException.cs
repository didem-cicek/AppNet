using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class AlreadyHaveCategoryException : Exception
    {
        public AlreadyHaveCategoryException(string categoryName) : base($"{categoryName} isimli bir kategori zaten kayıtlı.")
        {

        }
    }
}
