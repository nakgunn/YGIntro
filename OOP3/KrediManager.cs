using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Classtan farkı Hesapla() metodunun içinde her zaman aynı işlemi yaptırmayacağız.
    // Her kredi bu interface içerisindeki metodları içermek zorundadır. Yoksa hata alırız.
    // interface - şablon
    // Genellikle operasyonel metodlarda kullanılır.
    // İnterfaceler de alt classın referans numarasını tutabilirler.
    interface IKrediManager
    {
        public void Hesapla();
        public void BiseyYap();
        
    }
}
