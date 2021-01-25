using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " Eklendi");
        }
        public void MusteriListele(Musteri []musteriler)
        {
            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id+" "+musteri.Adi+" "+musteri.Soyadi);
            }
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " Silindi");
        }
    }
}
