using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}


            List<string> isimler2 = new List<string> { "Murat", "Kereö", "Halil" };
            foreach (string item in isimler2)
            {
                Console.WriteLine(item);
            }
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
 