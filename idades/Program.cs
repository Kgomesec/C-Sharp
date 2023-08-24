using System.Globalization;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        string pessoa1, pessoa2;
        int idade1, idade2;

        Console.WriteLine("Dados da primeira pessoa: ");
        Console.Write("Nome: ");
        pessoa1 = Console.ReadLine();
        Console.Write("Idade: ");
        idade1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da segunda pessoa: ");
        Console.Write("Nome: ");
        pessoa2 = Console.ReadLine();
        Console.Write("Idade: ");
        idade2 = int.Parse(Console.ReadLine());

        double media = ((double)idade1 + idade2) / 2;
        Console.WriteLine();
        Console.WriteLine("A idade média de " + pessoa1 + " e " + pessoa2 + " é de " + media.ToString("F1", CI) + " anos");

    }
}