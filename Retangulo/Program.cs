using System.Globalization;
using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        double largura, altura, area, perim, diag, res;

        Console.Write("Base do retangulo: ");
        largura = double.Parse(Console.ReadLine(), CI);

        Console.Write("Altura do retangulo: ");
        altura = double.Parse(Console.ReadLine(), CI);

        area = largura * altura;
        Console.WriteLine("AREA = " + area.ToString("F4", CI));

        perim = 2 * (largura + altura);
        Console.WriteLine("PERIMETRO = " + perim.ToString("F4", CI));

        res = Math.Pow(largura,2) + Math.Pow(altura, 2); 
        diag = Math.Sqrt(res);
        Console.WriteLine("DIAGONAL = " + diag.ToString("F4", CI));

    }
}