namespace CalculoCircunferencia
{
    class Calculadora
    {
        public static double Pi = 3.14;
        public static double CalculaCircunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public static double CalculaVolume(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
    }
}

// Atributos e meetódos setados todos como estáticos,
// permitindo que eu simplesmente chame a classe e seus
// atributos e métodos, sem a necessidade de ter que
// instanciar esta classe
