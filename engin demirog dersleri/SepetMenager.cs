using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetMenager
    {
        //naming convertion
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
