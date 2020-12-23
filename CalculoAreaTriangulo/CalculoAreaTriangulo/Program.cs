using System;
using System.Globalization;

namespace CalculoAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            // x e y aqui precisam ser tipificadas, e o são como uma 
            // variável do tipo Triangulo, pois elas irão receber o 
            // tipo Triangulo()
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Digite as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areaY.ToString("F4"), CultureInfo.InvariantCulture);

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            } else if (areaX < areaY)
            {
                Console.WriteLine("Maior área: Y");
            } else
            {
                Console.WriteLine("Os triangulos possuem a mesma área");
            }
        }
    }
}
