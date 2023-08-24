internal class Program
{
    private static void Main(string[] args)
    {
        string[] lines = Console.ReadLine().Split(" ");
        
        int m = int.Parse(lines[0]);
        int n = int.Parse(lines[1]);

        int[,] mat = new int[m, n];
        for(int i = 0; i<m; i++)
        {
            string[] matriz = Console.ReadLine().Split(" ");
            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(matriz[j]);
            }
        }

        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i, j] == x)
                {
                    Console.WriteLine("Position " + i + "," + j + ":");

                    if (j > 0)
                    {
                        Console.WriteLine("Left: " + mat[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Up: " + mat[i - 1, j]);
                    }
                    if (j < n - 1)
                    {
                        Console.WriteLine("Right: " + mat[i, j + 1]);
                    }
                    if (i < m - 1)
                    {
                        Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }             
            }
        }
    }
}