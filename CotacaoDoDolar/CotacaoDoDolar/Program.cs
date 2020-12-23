using System;
using System.Globalization;

namespace CotacaoDoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Conversor de Moeda!");
            Console.Write("Qual é a cotação do dolar? ");
            double cotacaoDoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidadeDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorASerPago = ConversorDeMoeda.CalculaValorASerPago(cotacaoDoDolar, quantidadeDolares);

            Console.WriteLine("Valor a ser pago em reais: " + valorASerPago.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
