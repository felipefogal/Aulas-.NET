using System;

namespace myApp
{
    class FindWords
    {
        public static string WhatsTheMusic()
        {
            string musicaOriginal = "You say goodbye, and I say hello";
            return musicaOriginal;
        }

        public static void FindElementsInMusic()
        {
            string music = FindWords.WhatsTheMusic();
            Console.WriteLine(music.Contains("goodbye"));
            Console.WriteLine(music.Contains("greetings"));
        }

        public static void FindEndsElementInMusic()
        {
            string music = FindWords.WhatsTheMusic();
            Console.WriteLine(music.EndsWith("goodbye"));
            Console.WriteLine(music.EndsWith("hello"));
        }

        public static void FindStartsElementInMusic()
        {
            string music = FindWords.WhatsTheMusic();
            Console.WriteLine(music.StartsWith("You"));
            Console.WriteLine(music.StartsWith("hello"));
        }
    }
}