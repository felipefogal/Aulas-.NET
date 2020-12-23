using System;
using System.Collections.Generic;
using System.Text;

namespace CotacaoDoDolar
{
    class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double CalculaValorASerPago(double cotacao, double dolares)
        {
            return cotacao * dolares + (cotacao * dolares * IOF);
        }
    }
}
