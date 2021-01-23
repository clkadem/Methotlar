using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : "+urun.Adi);

        }
        public void Ekle2(string urunadi,string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " +urunadi);
        }
    }
}
