using System;
using System.Globalization;

namespace FormulaDeHeron
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
             x.A = double.Parse(Console.ReadLine(), CI);
             x.B = double.Parse(Console.ReadLine(), CI);
             x.C = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
             y.A = double.Parse(Console.ReadLine(), CI);
             y.B = double.Parse(Console.ReadLine(), CI);
             y.C = double.Parse(Console.ReadLine(), CI);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CI));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CI));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior Área: X");
            }
            else
            {
                Console.WriteLine("Maior Área: Y");
            }
        }
    }
}