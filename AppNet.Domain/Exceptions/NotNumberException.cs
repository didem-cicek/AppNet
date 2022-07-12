using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class NotNumberException : Exception
    {
        public NotNumberException(string control) : base($"{control} isimli alana sayı değeri girmelisiniz!")
        {

        }
    }
}
