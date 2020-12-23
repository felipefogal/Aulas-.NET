using System;
using System.Globalization;

namespace ExercicioVetoresProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vetorProduto = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Necessário instanciar o Produto toda vez que ele for ler e gravar na array
                // de Produtos, pois os dados do tipo classes em arrays precisam ser instanciados um 
                // a um (o que faz todo sentido). No tipo structs, não é necessário
                vetorProduto[i] = new Produto { Nome = nomeProduto, Preco = precoProduto };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                // Para acessar os valores de um determinado indice da array, neste caso somente 
                // o Preco, coloca-se ".<NomeDaParada>" para acessá-lo, aqui, vetorProdutos[i].Preco
                soma += vetorProduto[i].Preco;
                Console.WriteLine("Produto " + i + 1 + ": " + vetorProduto[i].Nome + " com o preço: " + vetorProduto[i].Preco.ToString("F2", CultureInfo.InvariantCulture));
            }

            double mediaProdutos = soma / n;
            Console.WriteLine("A média dos valores dos produtos é: " + mediaProdutos.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
