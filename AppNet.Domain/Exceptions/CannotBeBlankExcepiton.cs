using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Exceptions
{
    public class CannotBeBlankExcepiton : Exception
    {
        public CannotBeBlankExcepiton(string notBlank) : base($"{notBlank} alanı boş bırakmayınız!") 
        { 
        }

        
    }
}
