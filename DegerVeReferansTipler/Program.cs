using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; // sayi1 değeri kopyaladı sayi2 ile işi bitti. işimiz stack ile.
            sayi2 = 65;
            // sayi1 ?? 30
            
            // int, decimal, float, double, bool = değer tip


            int[] sayilar1 = new int[] { 10, 20, 30 }; // sayilar1 için örn: 101 ref numarasıyla dizi elemanlarını tuttu.
            int[] sayilar2 = new int[] { 100, 200, 300 }; // sayilar2 için örn: 102 ref numarasıyla dizi elemanlarını tuttu.
            sayilar1 = sayilar2; // Heap sayilar1'in referans numarası sayilar2'nin referans numarasını aldı. yani sayilar1 ref nu=102 oldu. ve 101 ref numarası boşluğa düştü. Gelecekte Garbage Collector ile bunları bellekten temizleyeceğiz.
            sayilar2[0] = 999; // sayilar2 ve sayilar1'in ref numaraları aynı old için, sayilar1'in de sıfırıncı elemanı 999 oldu.
            // sayilar1[0] ?? 999 ---> sonuç bu yüzden 999 oldu.

            // array, class, interface = referans tip
        
        
        }
    }
}
