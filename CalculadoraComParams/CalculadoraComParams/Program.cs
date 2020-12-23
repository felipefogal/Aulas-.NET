using System;

namespace CalculadoraComParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui é necessário instanciar o vetor pois 
            // na classe Calculadora não estamos usando o
            // params
            //int soma1 = Calculadora.Soma(new int[] { 2, 3 });
            //int soma2 = Calculadora.Soma(new int[] { 2, 5, 3 });

            // Usando o params na função Soma da classe
            // Calculadora, basta passar os temos da array
            // como parametros de uma função, com a facilidade  
            // de não termos que instanciar a array, deixando
            // o código muito menos verboso
            int soma1 = Calculadora.Soma(2, 3);
            int soma2 = Calculadora.Soma(2, 5, 3);
            int soma3 = Calculadora.Soma(12, 34, 44, 12, 45, 65, 87, 99);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);
        }
    }
}
