using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp
{
    internal class Utilities
    {
        //Verificare isdigitonly
        public static bool IsDigitOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        //Functie validare brand
        public bool ValidareBrand(string brand)
        {
            if (brand == "Samsung")
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Functie verificare shape 
        
    }
}
