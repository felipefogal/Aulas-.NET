using System;

namespace AulaMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando a matriz
            //double[,] mat = new double[2, 3];
            //Console.WriteLine(mat.Length);
            //Console.WriteLine(mat.Rank);
            //Console.WriteLine(mat.GetLength(0));
            //Console.WriteLine(mat.GetLength(1));

            Console.Write("Numero de itens da matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());

            // Instanciando a matriz
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write($"Entre com um numero na linha {i} e coluna {c}: ");
                    int nCol = int.Parse(Console.ReadLine());
                    mat[i, c] = nCol;
                }

            }
            Console.WriteLine();
            Console.Write("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (mat[i, c] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Negative numbers: " + count);
        }
    }
}
