using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for (int i = 0; i<n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Item " + i + " é: " + vetor[i].ToString(CultureInfo.InvariantCulture));
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }

            double avg = soma / n;
            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
