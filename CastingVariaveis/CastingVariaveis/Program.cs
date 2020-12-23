using System;

namespace CastingVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            float b;

            //Feito um casting para poder receber o valor de double, porém 
            // o casting pode ocorrer perda de dados
            //Do contrário, é possível, pois a variável do tipo double possui 8 bytes, e
            // e a do tipo float, 4 bytes. Logo, double > float, sendo possúvel fazer a 
            // conversão do tipo implícita
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            //Exemplo mostrando a perda de valores no casting, uma vez que 
            // o int só aceita números inteiros
            int c;
            c = (int)a;
            Console.WriteLine(c);

            //Necessário fazer o casting aqui pq o compilador faz uma
            // divisão exata pois os valores de a e b são ints
            int _a = 5;
            int _b = 2;
            double resultado = (double)_a / _b;
            Console.WriteLine(resultado);


        }
    }
}
