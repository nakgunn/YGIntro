using System;
using System.Collections.Generic;

namespace Colllections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ctrl c + k - ctrl c + u

            //// 4 elemanlı tanımlanan bir diziye 5. elemanı ekleyemeyiz.
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //// böyle yaparsak 4. eleman ilker olur ancak 0,1,2,3 yok olur. - referans tipten dolayı.
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker"); // eleman sayısını arttır. Elemana İlker de.
            Console.WriteLine("\n" + isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
