using EstoqueProdutos;
using System;
using System.Globalization;

namespace EstoqueProduto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtd);
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int rmv = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(rmv);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}