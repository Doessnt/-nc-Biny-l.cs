using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcsions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matematik.konus();

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin");
            //string secim = Console.ReadLine().ToLower();
            //if (secim == "toplama") { Matematik.toplama(); }
            //else if (secim == "çıkarma") { Matematik.cıkarma(); }
            //else if (secim == "çarpma") { Matematik.çarpma(); }
            //else if (secim == "bölme") { Matematik.bolme(); }
            /*Overload = bir metotu aynı isimle ama farklı şekillerde birden fazla kez tanımlamaya denir. :D?*/
         



            Console.ReadKey();
        }

    }
    class parametreli{
        public static void toplama(int sayi1 = 1, int sayi2 = 0)
        {
           
            Console.WriteLine(sayi2 + sayi1);

        }


    }




    class Matematik
    {
       public static void toplama() {
            Console.WriteLine("1.sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi2 + sayi1);

        }
        public static void çarpma()
        {
            Console.WriteLine("1.sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi2 * sayi1);

        }
        public static void cıkarma()
        {
            Console.WriteLine("1.sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi2 - sayi1);

        }
        public static void bolme()
        {
            Console.WriteLine("1.sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi2 / sayi1);

        }

    }

}
