using System;

namespace Inheritance_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mahmut";
            musteri1.Soyadi = "Kanaryaoğlu";
            musteri1.TcNo = "1111111111";
            musteri1.Id = 1;
            //............
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Apple";
            musteri2.VergiNo = "12346789";
            //.............
            Musteri musteri3 = new GercekMusteri(); // bellekteki referans
            Musteri musteri4 = new TuzelMusteri(); // bellekteki referans

            //.............
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
