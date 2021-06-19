using System;
using System.Globalization;
using System.Text.Encodings;

namespace EdgeGen
{
    static class extend {
        public static bool Contains(this string src, params string[] terms)
        {
            bool found = false;
            foreach(var Term in terms)
            {
                if(src.Contains(Term))
                    found = true;
            }
            return found;
        }
    }

    class Program
    {
        public static Random rand = new Random();

        public static T GetRand<T>(T[] collection)
        {
            return collection[rand.Next(collection.Length)];
        }

        public static bool CoinFilp() =>
            Program.rand.Next(2) == 1 ? true : false;

        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string Swordname = $"{WeaponTitle.Generate()} {WeaponType.Generate()} {WeaponFlair.Get_Flair()}";
                TextInfo myTI = new CultureInfo("en-US",false).TextInfo;
                Swordname = Swordname.Replace(" ,", ",").Replace(",","");
                Swordname = myTI.ToTitleCase(Swordname).Replace("Of", "of").Replace("The", "the");

                Console.WriteLine(Swordname);
                Console.ResetColor();
            }
        }
    }
}
