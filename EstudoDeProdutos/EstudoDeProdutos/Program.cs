using System;
using System.Globalization;

namespace EstudoDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produto = new Produtos();

            Console.WriteLine("Entre com o nome dos produtos: ");
            Console.Write("Nome do produto: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do produto no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite a quantidade a ser acrescida: ");
            int quantidadeAdicionada = int.Parse(Console.ReadLine());
            produto.AdicionaProdutos(quantidadeAdicionada);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.Write("Digite a quantiadde a ser removida: ");
            int quantidadeRemovida = int.Parse(Console.ReadLine());
            produto.RemoveProdutos(quantidadeRemovida);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
        }
    }
}
