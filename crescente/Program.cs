internal class Program
{
    private static void Main(string[] args)
    {
        int x, y;

        Console.WriteLine("Digite dois numeros: ");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if(x > y)
        {
            Console.WriteLine("DECRESCENTE!");
        }
        else if(x < y)
        {
            Console.WriteLine("CRESCENTE!");
        } 

        while (x != y) {
            Console.WriteLine("Digite outros dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("DECRESCENTE!");
            }
            else if (x < y)
            {
                Console.WriteLine("CRESCENTE!");
            }
        }

    }
}