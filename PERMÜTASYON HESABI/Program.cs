using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PERMÜTASYON_HESABI
{
    class Program
    {
        static int fakt(int x)
        {
            int carpim = 1;
            for (int i = 1; i <= x; i++)
            {
                carpim *= i;
            }
            return carpim;

        }

        static int per(int a, int b)
        {
            int sonuc;

            sonuc = fakt(a) / fakt(a - b);

            return sonuc;
        }

        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("x değerini giriniz");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b değerini giriniz");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(per(a, b)); 

        }

       
       
    }
}
