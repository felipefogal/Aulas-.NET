using System;

namespace VetorComForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Maria", "Bob", "João" };

            // Sem usar foreach, for normal
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("------------------------------------");
            // Usando FOREACH
            // Não é feitiçaria, é tecnologia!
            foreach (string nomes in vetor) {
                Console.WriteLine(nomes);
            }
        }
    }
}
