using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖDEV


            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("--------------EKLE---------------");
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Elif";
            musteri1.Soyadi = "Kadi";
            musteriManager.MusteriEkle(musteri1);

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Esra";
            musteri2.Soyadi = "Kadi";
            musteriManager.MusteriEkle(musteri2);

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2 };

            Console.WriteLine("--------------LİSTELE---------------");
            musteriManager.MusteriListele(musteriler);

            Console.WriteLine("--------------SİL---------------");
            musteriManager.MusteriSil(musteri1);


        }
    }
}
