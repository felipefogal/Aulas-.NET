using System;
using System.Globalization;

namespace ExercicioContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente; // Aqui a variavel contaCorrente consegue ter contexto
                                         // em todo código, não só dentro do if instanciado

            Console.WriteLine("Olá, exercicio de Calculo de Conta!");
            Console.WriteLine();
            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string titularDaConta = Console.ReadLine();
            
            Console.Write("Haverá deposito inicial?: ");
            string querDepositoInicial = Console.ReadLine();
            querDepositoInicial = querDepositoInicial.ToUpper();
            if (querDepositoInicial == "S" || querDepositoInicial == "SIM")
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaCorrente = new ContaCorrente(conta, titularDaConta, valorDepositoInicial);
            } else
            {
                contaCorrente = new ContaCorrente(conta, titularDaConta);
            }
            Console.WriteLine("Dados da conta: ");
            contaCorrente.ExibeInfosDaConta();
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaCorrente.Deposito(valorDeposito);
            contaCorrente.ExibeInfosAtualizadas();
            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaCorrente.Saque(valorSaque);
            contaCorrente.ExibeInfosAtualizadas();
        }
    }
}
