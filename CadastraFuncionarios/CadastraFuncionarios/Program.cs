using System;
using System.Globalization;

namespace CadastraFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionarioA, funcionarioB;
            funcionarioA = new Funcionarios();
            funcionarioB = new Funcionarios();

            Console.Write("Digite o nome do Primeiro Funcionario: ");
            funcionarioA.Nome = Console.ReadLine();
            Console.Write("Digite a idade do Primeiro Funcionário: ");
            funcionarioA.Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o salário do Primeiro Funcionário: ");
            funcionarioA.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o nome do Segundo Funcionário: ");
            funcionarioB.Nome = Console.ReadLine();
            Console.Write("Digite a idade do Segundo Funcionário: ");
            funcionarioB.Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o salário do Segundo Funcionário: ");
            funcionarioB.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (funcionarioA.Salario + funcionarioB.Salario) / 2;

            Console.WriteLine("A média salarial dos dois funcionários é: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));

            if (funcionarioA.Idade > funcionarioB.Idade)
            {
                Console.WriteLine($"O funcionário {funcionarioA.Nome} é o funcionário mais velho");
            } else if (funcionarioA.Idade < funcionarioB.Idade) 
            {
                Console.WriteLine($"O funcionario {funcionarioB.Nome} é o funcionário mais velho");
            } else
            {
                Console.WriteLine($"Os funcionários {funcionarioA.Nome} e {funcionarioB.Nome} possuem a mesma idade");
            }
        }
    }
}
