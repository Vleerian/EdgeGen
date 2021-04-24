using System;

namespace EdgeGen
{
    class Program
    {
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
