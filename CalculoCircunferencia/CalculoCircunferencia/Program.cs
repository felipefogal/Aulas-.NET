using System;
using System.Globalization;

namespace CalculoCircunferencia
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // A chamada abaixo foi feita direto pelo nome da classe, pois 
            // na verdade foi criada uma classe estática, onde eu acrescento
            // o prefixo "static" na declaração do nome dos atributos e metódos
            // da classe. Neste contexto, como os valores de PI são sempre os
            // mesmos, não importa o númrero de instâncias de classes que eu
            // crie, os valores serão sempre os mesmos
            double circunferencia = Calculadora.CalculaCircunferencia(raio);
            double volume = Calculadora.CalculaVolume(raio);

            Console.WriteLine("A circunferencia é: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O volume é: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
