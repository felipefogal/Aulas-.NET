namespace myApp
{
    class ChangeNames
    {
        public static string FraseOriginal()
        {
            string sayHello =  "Hello World!";
            return sayHello;
        }

        public static string TrocarFraseOriginal()
        {
            string nomeOriginal = ChangeNames.FraseOriginal();
            string nomeAlterado = nomeOriginal.Replace("Hello", "Greetings");
            return nomeAlterado;
        }

        public static string TrocarFraseUpperCase()
        {
            string nomeOriginal = ChangeNames.FraseOriginal();
            string nomeAlteradoComUpperCase = nomeOriginal.ToUpper();
            return nomeAlteradoComUpperCase;
        }

        public static string TrocarFraseLowerCase()
        {
            string nomeOriginal = ChangeNames.FraseOriginal();
            string nomeAlteradoComLowerCase = nomeOriginal.ToLower();
            return nomeAlteradoComLowerCase;
        }
    }
}