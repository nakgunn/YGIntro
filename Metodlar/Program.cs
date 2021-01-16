using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                // urunler dizisi içerisindeki her dizi elemanının kaç değeri varsa o kadar döner.
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("###########################");
            }

            Console.WriteLine("---------Metodlar-----------");

            //instance - örnek
            // re-usibility - yeniden kullanılabilirlik sağladı.
            //encaptulation - ürün özelliklerini parametre'de kullanmayız. Sonradan parametre eklemek gerekirse patlar.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            // buradaki gibi patlar. stokadedini sonradan eklersek kızarır.
            sepetManager.Ekle2("Armut", "Sarı Armut", 12, 10);
            sepetManager.Ekle2("Üzüm", "Sultani Üzümü", 14, 8);
            sepetManager.Ekle2("Zeytin", "Akhisar Sele Zeytini", 16, 2);



        }
    }
}
