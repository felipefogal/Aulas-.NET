using System;

namespace ExercicioFixacaoAluguelQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] listaEstudantes = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qntQuartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qntQuartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: " );
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                listaEstudantes[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i =0; i <10; i++)
            {
                if (listaEstudantes[i] != null)
                {
                    Console.WriteLine(i + ": " + listaEstudantes[i]);
                }
            }
        }
    }
}
