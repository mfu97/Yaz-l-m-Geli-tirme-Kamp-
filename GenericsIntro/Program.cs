using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.length);
            isimler.Add("Kerem");
            Console.WriteLine(isimler.length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
