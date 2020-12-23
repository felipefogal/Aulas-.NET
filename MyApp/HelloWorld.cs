namespace myApp
{
    class HelloWorld
    {
        public static string ExibirMeuNome()
        {
            {
                string aName = "Eu";
                string bName = "Mesmo";
                string fullName = aName + " " + bName;
                string nome = $"Meu nome é: {fullName}";
                return nome;
            }
        }

        public static string ExibirHelloWorld()
        {
            string helloWorld = "Hello World!";
            string meuPrimeiroPrograma = "Neu primeiro programa em .NET Core. Só não sei se funciona esta bagaça...";
            string hellosInterpolados = ($"{helloWorld} {meuPrimeiroPrograma}");
            return hellosInterpolados;
        }

        public static double ExibirContinhaBesta()
        {
            double continha = 1 + 2;
            return continha;
        }
    }
}