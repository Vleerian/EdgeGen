using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace EdgeGen
{
    class Program
    {
        static string[] Merge(string[] collection1, string[] collection2)
        {
            HashSet<string> pruned = new();
            foreach(string i in collection1)
                pruned.Add(i);
            foreach(string i in collection2)
                pruned.Add(i);
            return pruned.ToArray();
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                string title = "";
                if(Sword_Gen.rand.Next(2) == 0)
                    title += Sword_Gen.Get_Prefix() + " ";
                title += Sword_Gen.Get_Title();

                Console.WriteLine($"{title}, {Sword_Gen.Get_Description()} {Sword_Gen.Get_Type()} of {Sword_Gen.Get_Flair()}");
            }
        }
    }
}
