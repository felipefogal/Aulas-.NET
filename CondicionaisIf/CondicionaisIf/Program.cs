using System;

namespace CondicionaisIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Digite um número inteiro, seu desinfeliz: ");
            //int numeroInteiro = int.Parse(Console.ReadLine());

            //if (numeroInteiro % 2 == 0)
            //{
            //    Console.WriteLine("Teu número é par, seu desinfeliz!");
            //}
            //else
            //{
            //    Console.WriteLine("Teu número é impar, seu desinfeliz!");
            //}

            Console.Write("Digite o valor cheio da hora, seu desinfeliz: ");
            int horaCheia = int.Parse(Console.ReadLine());

            if (horaCheia < 12)
            {
                Console.WriteLine($"Bom dia, desinfeliz! São {horaCheia} horas. Seja desinfeliz!");
            }
            else if (horaCheia >= 12 !& horaCheia <= 18)
            {
                Console.WriteLine($"Boa tarde, desinfeliz! São {horaCheia} horas. Seja desinfeliz!");
            } 
            else
            {
                Console.WriteLine($"Boa noite, desinfeliz! São {horaCheia} horas. Seja desinfeliz!");
            }
        }
    }
}
