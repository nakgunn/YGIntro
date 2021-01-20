using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  // generic classa çalışacağımız tipi söylememiz gerekiyor.
    { 
        T[] items;
        //constructor
        public MyList() // başladığımızda sıfır elemanlı olsun diyeceğiz.
        {
            items = new T[0];
        }
        public void Add(T item) // T hangi tipi verirsek o olsun || Ben sana hangi tür eleman dersem o tür alacak demek = T, string veya int de diyebilirdik ancak sadece onu verebilirdik.
        {
            T[] tempArray = items; // geçici diziyle elemanları burada tutacağız.
            items = new T[items.Length + 1]; // dizideki mevcut eleman sayısını bir arttır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
