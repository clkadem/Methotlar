using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 10;
            int s2 = 30;
            s1 = s2;
            s2 = 65;

            int[] sayilar = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(s1+" "+sayilar[0]);
        }
    }
}
