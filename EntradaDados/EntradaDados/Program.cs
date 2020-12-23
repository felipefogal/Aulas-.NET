using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------ Input com conveersão ------------------
            //Console.Write("Digite o valor do primeiro número: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.Write("Digite o valor do multiplicador: ");
            //int multiplicador = int.Parse(Console.ReadLine());

            //Console.Write("Digite um valor do tipo double: ");
            //double db = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //int valorDaConta = n1 * multiplicador;

            //Console.Write("Digite o seu sexo, salafrário: ");
            //char ch = char.Parse(Console.ReadLine());

            //Console.Write("Digite o seu nome, salafrário: ");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Seu nome é: " + nome);
            //Console.WriteLine("Sexo: " + ch);
            //Console.WriteLine("O resultado da conta é: " + valorDaConta);
            //Console.WriteLine("O número double é " + db.ToString(CultureInfo.InvariantCulture));

            Console.Write("Digite o nome, sexo, idade e altura do maninho: ");
            string[] vetor = Console.ReadLine().Split(' ');
            string nomeDoManinho = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeDoManinho);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));

            //----------------- Input de dados simples -----------------
            ////string frase = Console.ReadLine();
            ////string x = Console.ReadLine();
            ////string y = Console.ReadLine();
            ////string z = Console.ReadLine();

            //// Primeiro metódo para trabalhar com uma array 
            ////string s = Console.ReadLine();
            ////string[] v = s.Split(' ');
            ////string a = v[0];
            ////string b = v[1];
            ////string c = v[2];

            ////Segundo método para trabalhar com uma array
            //string[] v = Console.ReadLine().Split(' ');
            //string a = v[0];
            //string b = v[1];
            //string c = v[2];

            //Console.WriteLine("Você digitou: ");
            ////Console.WriteLine(frase);
            ////Console.WriteLine(x);
            ////Console.WriteLine(y);
            ////Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
        }
    }
}
