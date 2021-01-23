using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementation - uygulama
            // Operasyonel Metodlar ile - Entities üzerinde işlemler yapılır.

            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Necati";
            //musteri1.Soyadi = "Akgun";
            //musteri1.Id = 1;
            //musteri1.TcNo = "123123123123";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";  // Şirket adı musteri ile ilgili bir kavram değildir! Mesela MusteriTipi diye bir özellik ile bölünmemeli.

            // Gerçek - Tüzel isim  olarak birbirine benziyor diye birbirinin yerine kullanılamaz.

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Necati";
            musteri1.Soyadi = "Akgün";
            musteri1.TcNo = "112233445";

            // AKGUN COORP

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "AKGUN COORP";
            musteri2.VergiNo = "1234567890";

            // Musteri sınıfı hem gerçek müşteriden hem de tüzel müşteriden referans alabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            




        }
    }
}
