using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotacao
{
    internal class ConversorDeMoeda
    {

        public static double IOF = 6.0;

        public static double Conversor(double cotacao,double dolar)
        {
            return (dolar + dolar * IOF / 100) * cotacao;
        }
    }
}
