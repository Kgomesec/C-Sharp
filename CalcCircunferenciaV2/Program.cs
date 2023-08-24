using System;
using System.Globalization;

namespace CalcCircunferenciaV2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculadora calc = new Calculadora();

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CI));
            Console.WriteLine("Volume: " + volume.ToString("F2", CI));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CI));
        }
    }
}