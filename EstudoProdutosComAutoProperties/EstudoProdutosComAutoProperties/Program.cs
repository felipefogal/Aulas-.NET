using System;
using System.Globalization;

namespace EstudoDeProdutosComAutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindos ao cadastro de produtos da hora!");
            Console.Write("Digite o nome do produto: ");
            string nome_produto = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            double preco_produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a quantidade do produto: ");
            int quantidade_produto = int.Parse(Console.ReadLine());

            Produtos produto = new Produtos(nome_produto, preco_produto, quantidade_produto);

            Console.WriteLine($"Produto: {produto.Nome}, Preco: ${produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantidade: {produto.Quantidade}");

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            quantidade_produto = int.Parse(Console.ReadLine());
            produto.AdicionaProdutos(quantidade_produto);
            Console.WriteLine("A nova quantidade em estoque é: " + produto.Quantidade);
            Console.WriteLine("O valor total do estoque é: $" + produto.ValorTotalEmEstoque());

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos retirada do estoque: ");
            quantidade_produto = int.Parse(Console.ReadLine());
            produto.RemoveProdutos(quantidade_produto);
            Console.WriteLine("A nova quantidade em estoque é: " + produto.Quantidade);
            Console.WriteLine("O valor total do estoque, atualizado, é: $" + produto.ValorTotalEmEstoque());

            Console.WriteLine();
            Console.Write("Digite o nome do outro produto: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Digite o valor do novo produto: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade do novo produto: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Produto: {produto.Nome}, Preço: ${produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantidade: {produto.Quantidade}");
        }
    }
}
