using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.MetodosHelloWorld();

            Program.MetodosTrimName();

            Program.MetodosChangeNames();

            Program.MetodoFindWords();
        }
        
        private static void MetodosHelloWorld()
        {
            string meuNome = HelloWorld.ExibirMeuNome();
            Console.WriteLine(meuNome);

            string helloWorld = HelloWorld.ExibirHelloWorld();
            Console.WriteLine(helloWorld);

            double continhaIdiota = HelloWorld.ExibirContinhaBesta();
            Console.WriteLine(continhaIdiota);
        }

        private static void MetodosTrimName()
        {
            string nomeSemTrim = TrimName.NomeConfuso();
            Console.WriteLine($"[{nomeSemTrim}]");

            string nomeComTrim = TrimName.ExibirNomeComTrim();
            Console.WriteLine($"[{nomeComTrim}]");

            string nomeComTrimNoInicio = TrimName.ExibirNomeComTrimStart();
            Console.WriteLine($"[{nomeComTrimNoInicio}]");

            string nomeComTrimNoFinal = TrimName.ExibirNomeComTrimEnd();
            Console.WriteLine($"[{nomeComTrimNoFinal}]");
        }

        private static void MetodosChangeNames()
        {
            string nomeOriginalParaExibicao = ChangeNames.FraseOriginal();
            Console.WriteLine(nomeOriginalParaExibicao);

            string nomeAlterado = ChangeNames.TrocarFraseOriginal();
            Console.WriteLine(nomeAlterado);

            string nomeAlteradoComUpperCase = ChangeNames.TrocarFraseUpperCase();
            Console.WriteLine(nomeAlteradoComUpperCase);

            string nomeAlteradoComLowerCase = ChangeNames.TrocarFraseLowerCase();
            Console.WriteLine(nomeAlteradoComLowerCase);
        }

        private static void MetodoFindWords()
        {
            string musicaOriginal = FindWords.WhatsTheMusic();
            FindWords.FindElementsInMusic();
            FindWords.FindStartsElementInMusic();
            FindWords.FindEndsElementInMusic();
        }
    }
}
