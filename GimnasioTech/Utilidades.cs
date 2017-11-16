using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GimnasioTech
{
    public static class Utilidades
    {
        public static int TOINT(string num)
        {
            int numero = 0;
            int.TryParse(num, out numero);
            return numero;
        }

        public static decimal TODECIMAL(string num)
        {
            decimal numero = 0;
            decimal.TryParse(num, out numero);
            return numero;
        }
    }
}
