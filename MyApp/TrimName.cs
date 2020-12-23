using System;

namespace myApp
{
    class TrimName
    {
        public static string NomeConfuso()
        {
            string nomeConfuso = "            Hello World!            ";
            return nomeConfuso;
        }
        public static string ExibirNomeComTrim()
        {
            string nomeAlteradoComTrim = TrimName.NomeConfuso();
            string nomeCorrigidoComTrim = nomeAlteradoComTrim.Trim();
            return nomeCorrigidoComTrim;
        }

        public static string ExibirNomeComTrimStart()
        {
            string nomeAlteradoComStartTrim = TrimName.NomeConfuso();
            string nomeCorrigidoComStartTrim = nomeAlteradoComStartTrim.TrimStart();
            return nomeCorrigidoComStartTrim;
        }

        public static string ExibirNomeComTrimEnd()
        {
            string nomeAlteradoComEndTrim = TrimName.NomeConfuso();
            string nomeCorrigidoComEndTrim = nomeAlteradoComEndTrim.TrimEnd();
            return nomeCorrigidoComEndTrim;
        }
    }
}