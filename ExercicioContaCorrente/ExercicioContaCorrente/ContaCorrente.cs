using System;
using System.Globalization;

namespace ExercicioContaCorrente
{
    class ContaCorrente
    {
        public int NumeroDaConta { get; private set; }
        public string NomeTitularDaConta { get; set; }
        public double SaldoConta { get; private set; }

        public ContaCorrente(int numeroDaConta, string nomeTitularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            NomeTitularDaConta = nomeTitularDaConta;
        }

        public ContaCorrente(int numeroDaConta, string nomeTitularDaConta, double valorDepositoInicial) : this(numeroDaConta, nomeTitularDaConta)
        {
            Deposito(valorDepositoInicial);
        }

        public void Deposito(double valorDeposito)
        {
            SaldoConta += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            SaldoConta -= (valorSaque + 5.00);
        }

        public void ExibeInfosAtualizadas()
        {
            Console.WriteLine("Dados da conta atualizado: ");
            ExibeInfosDaConta();
        }

        public void ExibeInfosDaConta()
        {
            Console.WriteLine($"Conta {NumeroDaConta}, Titular: {NomeTitularDaConta}, " +
                $"Saldo ${SaldoConta.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
