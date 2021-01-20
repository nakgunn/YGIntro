using System;


namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // T'den dolayı ne verirsek o.
            MyList<string> isimler = new MyList<string>();
            MyList<int> sayilar = new MyList<int>();
        }
    }
}
