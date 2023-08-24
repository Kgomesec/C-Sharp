internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c, menor = 0; 
      
        Console.Write("primeiro valor: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("segundo valor: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("terceiro valor: ");
        c = int.Parse(Console.ReadLine());

        if(a < b && a < c)
        {
            menor = a;
        }
        else if(b < a && b < c)
        {
            menor = b;
        }
        else
        {
            menor = c;
        }

        Console.WriteLine("MENOR = " + menor);
    }
}