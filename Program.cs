using System;
using System.Globalization;
using System.Text.Encodings;

namespace EdgeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string Swordname = $"{Sword_Gen.Get_Title()}, {Sword_Gen.Get_Prefix()} {Sword_Gen.Get_Description()} {Sword_Gen.Get_Type()} {Sword_Gen.Get_Flair()}";
                TextInfo myTI = new CultureInfo("en-US",false).TextInfo;
                Swordname = myTI.ToTitleCase(Swordname).Replace("Of", "of").Replace("The", "the").Replace(" ,", ",");

                Console.WriteLine(Swordname);
            }
        }
    }
}
