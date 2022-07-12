using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class NotFoundCategoryException : Exception
    {
        public NotFoundCategoryException(string categoryName) : base($"{categoryName} isimli kategori bulunamadı.")
        {

        }
    }
}
