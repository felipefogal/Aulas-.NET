using System;
using System.Globalization;

namespace EstudoDeProdutos
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

            Console.WriteLine($"Produto: {produto.GetNome()}, Preco: ${produto.GetPreco().ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantidade: {produto.GetQuantidade()}");

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            quantidade_produto = int.Parse(Console.ReadLine());
            produto.AdicionaProdutos(quantidade_produto);
            Console.WriteLine("A nova quantidade em estoque é: " + produto.GetQuantidade());
            Console.WriteLine("O valor total do estoque é: $" + produto.ValorTotalEmEstoque());

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos retirada do estoque: ");
            quantidade_produto = int.Parse(Console.ReadLine());
            produto.RemoveProdutos(quantidade_produto);
            Console.WriteLine("A nova quantidade em estoque é: " + produto.GetQuantidade());
            Console.WriteLine("O valor total do estoque, atualizado, é: $"+ produto.ValorTotalEmEstoque());

            Console.WriteLine();
            Console.Write("Digite o nome do outro produto: ");
            nome_produto = Console.ReadLine();
            produto.SetNome(nome_produto);
            Console.Write("Digite o valor do novo produto: ");
            preco_produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.SetPreco(preco_produto);
            Console.Write("Digite a quantidade do novo produto: ");
            quantidade_produto = int.Parse(Console.ReadLine());
            produto.SetQuantidade(quantidade_produto);
            Console.WriteLine($"Produto: {produto.GetNome()}, Preço: ${produto.GetPreco().ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantidade: {produto.GetQuantidade()}");
        }
    }
}
