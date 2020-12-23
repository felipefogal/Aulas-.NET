using System;

namespace OpcionaisENullables
{
    class Program
    {
        static void Main(string[] args)
        {

            // A ? faz com que a variavel fique opcional,
            // logo, sendo uma opcional, pode receber valor
            // nulo, ou ser uma nullable
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            // O value lança uma exception caso o 
            // valor de uma variavel seja nula
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            } else
            {
                Console.WriteLine("X is null");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            } else
            {
                Console.WriteLine("Y is null");
            }

            // As duas interrogações ?? são o valor de 
            // coalescencia nula: serve para atribuir um 
            // valor qualquer a uma outra variável que esteja
            // recebendo uma variavel nula. Neste caso, a
            // variavel "a" receberá o valor 5
            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
