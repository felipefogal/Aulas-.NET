using System;

namespace Comparativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a == 10;
            bool c4 = a >= 10;
            bool c5 = a <= 10;
            bool c6 = a != 10;

            Console.WriteLine($"As condições são: {c1}, {c2}, {c3}, {c4}, {c5}, {c6}" );

            bool c7 = 2 > 3 && 4 != 5;
            Console.WriteLine($"A condição é {c7}");
            bool c8 = !(2 > 3) && 4 != 5;
            Console.WriteLine($"A condição é {c8}");
        }
    }
}
