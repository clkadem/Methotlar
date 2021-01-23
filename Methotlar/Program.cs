﻿using System;

namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");
            }



            Console.WriteLine("---------------Metotlar----------------");
            //encapsulation
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle2("Armut", "Yesil armut", 12);


            
        }
    }
}