using System;

namespace NumbersInCSharp
{
    class OperadoresMatematicos
    {
        private static int PrimeiroNumero()
        {
            int a = 18;
            return a;
        }

        private static int SegundoNumero()
        {
            int b = 6;
            return b;
        }
        public static void Adicao()
        {
            int primeiroNumero = OperadoresMatematicos.PrimeiroNumero();
            int segundoNumero = OperadoresMatematicos.SegundoNumero();
            Console.WriteLine(primeiroNumero + segundoNumero);
        }

        public static void Subtracao()
        {
            int primeiroNumero = OperadoresMatematicos.PrimeiroNumero();
            int segundoNumero = OperadoresMatematicos.SegundoNumero();
            Console.WriteLine(primeiroNumero - segundoNumero);
        }

        public static void Multiplicacao()
        {
            int primeiroNumero = OperadoresMatematicos.PrimeiroNumero();
            int segundoNumero = OperadoresMatematicos.SegundoNumero();
            Console.WriteLine(primeiroNumero * segundoNumero);
        }

        public static void Divisao()
        {
            int primeiroNumero = OperadoresMatematicos.PrimeiroNumero();
            int segundoNumero = OperadoresMatematicos.SegundoNumero();
            Console.WriteLine(primeiroNumero / segundoNumero);
        }
    }
}