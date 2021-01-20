using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation - yanlış veri göndermeyi engelliyor
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi. " );
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi. ");

        }

        // sayi1 ve sayi2 nin toplandıktan sonra değeri gönderilir. Bu fonk kullanmak için bir değişkene atamamız gerekir. Böylelikle sonucu (return ettiğimiz int'i) program.cs 'de kullanabiliriz.
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        // sayi1 ve sayi2 yi toplar ancak sadece ekrana yazdırır. Matematiksel işlem yapamazsın. Yani sonucun üzerinde çalışamazsın.
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }

    }
}
