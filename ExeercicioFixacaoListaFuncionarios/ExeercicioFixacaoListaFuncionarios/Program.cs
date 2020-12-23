using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExeercicioFixacaoListaFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int qntFunc = int.Parse(Console.ReadLine());
            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= qntFunc; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int idFunc = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameFunc = Console.ReadLine();
                Console.Write("Salary: ");
                double salFunc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(idFunc, nameFunc, salFunc));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idPesquisa = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.IdFuncionario == idPesquisa);
            if (func != null)
            {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.SalarioReajustado(porcentagem);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario objs in list)
            {
                Console.WriteLine(objs.IdFuncionario + ", " + objs.NomeFuncionario + ", $"
                    + objs.SalarioFuncionario.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
