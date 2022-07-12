using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Validations
{
    public static class Validations
    {
        public static void NullOrEmpty(this string value, string paramName)
        {
            if (string.IsNullOrEmpty(value)) {
                throw new ArgumentNullException(paramName, $"{paramName} değeri boş yada null  olamaz.");
                
        }}
        public static void NullOrEmpty(this int value, string paramName)
        {
            if (value != null)
                throw new ArgumentNullException(paramName, $"{paramName} değeri boş yada null  olamaz.");
        }
        public static void NullOrEmpty(this decimal value, string paramName)
        {
            if (value != null)
                throw new ArgumentNullException(paramName, $"{paramName} değeri boş yada null  olamaz.");
        }
        public static void NullOrEmpty(this short value, string paramName)
        {
            if (value != null)
                throw new ArgumentNullException(paramName, $"{paramName} değeri boş yada null  olamaz.");
        }
        public static void Zero(this decimal value, string paramName)
        {
            if (0 == value)
                throw new ArgumentException(paramName, $"{paramName} değeri 0 olamaz.");
        }
        public static void Zero(this ushort value, string paramName)
        {
            if (0 == value)
                throw new ArgumentException(paramName, $"{paramName} değeri 0 olamaz.");
        }
        public static void Zero(this int value, string paramName)
        {
            if (0 == value)
                throw new ArgumentException(paramName, $"{paramName} değeri 0 olamaz.");
        }
    }
}
