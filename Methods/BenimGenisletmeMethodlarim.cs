using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class BenimGenisletmeMethodlarim
    {
        public static string BasHarfiBuyut(this String value)
        {
            //
            // Uppercase the first letter in the string.
            //
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }
    }
}
