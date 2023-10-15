using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotaç_aoDolar
{
    internal class Dolar
    {
        public static double Iof = 5.00;

        public static double DolarParaReal(double quantia, double cotaco)
        {
            double total = quantia * cotaco;
            return total + total * Iof / 100.00;


        }
    }
}
