using Cotacao;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        Console.Write("Qual a cotação do dólar? ");
        double cotacao = double.Parse(Console.ReadLine(), CI);

        Console.Write("Quantos dólares você vai comprar? ");
        double compra = double.Parse(Console.ReadLine(), CI);

        double total = ConversorDeMoeda.Conversor(cotacao, compra);

        Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2", CI));

    }
}