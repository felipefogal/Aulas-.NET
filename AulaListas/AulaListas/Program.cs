using System;
using System.Collections.Generic;

namespace AulaListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sintaxe de declaração de uma list
            List<string> list = new List<string>();

            // Adicionando via comando add:
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            // Via insert, informar o indice:
            list.Insert(2, "Marco");

            foreach (string objs in list)
            {
                Console.WriteLine(objs);
            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------");
            foreach (string objs in list2)
            {
                Console.WriteLine(objs);
            }

            list.Remove("Alex");
            Console.WriteLine("----------------------");
            foreach (string objs in list)
            {
                Console.WriteLine(objs);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------");
            foreach (string objs in list)
            {
                Console.WriteLine(objs);
            }
        }
    }
}
