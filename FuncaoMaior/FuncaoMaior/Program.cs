using System;
using System.Globalization;

namespace FuncaoMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite três numeros, seu desincapaz!");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());

            //double resultado = Maior(n1, n2, n3);
            //Console.WriteLine("Maior = " + resultado);

            //RepeticaoWhile();

            RepeticaoFor();
        }

        static int Maior(int a, int b, int c)
        {
            int maior;
            if (a > b && a > c)
            {
                maior = a;
            } 
            else if (b > c)
            {
                maior = b;
            } 
            else
            {
                maior = c;
            }

            return maior;
        }

        static void RepeticaoWhile()
        {
            Console.Write("Digite um numero para calcular sua raiz quadrada: ");
            double numeroRaizQuadrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (numeroRaizQuadrada >= 0.0)
            {
                double resultado = Math.Sqrt(numeroRaizQuadrada);
                Console.WriteLine("A raiz quadrada é " + resultado.ToString("F4", CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero para calcular a raiz quadrada: ");
                numeroRaizQuadrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("O número digitado é negativo!");
        }

        static void RepeticaoFor()
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma é: " + soma);
        }

    }
}
