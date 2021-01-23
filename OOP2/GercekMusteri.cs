using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Individual Entity - Varlık Classı
    // Miras - Inheritence
    // Gerçek Müşteri bir Müşteridir. Müşteride olan herşey Gerçek müsteride de var olduğu kabul edilir.
    class GercekMusteri:Musteri
    {
        
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
