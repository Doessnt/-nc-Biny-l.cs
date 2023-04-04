using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data accses modifier
            /*
                public = Her app'e açık
                internal = Projeye özel
                privet => class a özel
                protected => Inheritens alınan classta erişilebilir.

             
             */


            //int total = ders.hesapla();
            //Console.WriteLine(total);

            //string nazi = ders.get_message();
            //Console.WriteLine(nazi);

            //int age = ders.get_age();
            //Console.WriteLine(age);
            //Console.WriteLine("islem sec");
            //string i = Console.ReadLine();
            //Console.WriteLine("1.sayı");
            //int user = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayı");
            //int user2 = Convert.ToInt32(Console.ReadLine());

            //if (i == "+") { Console.WriteLine(matematik.toplama(user, user2)); }
            //else if (i == "-") { Console.WriteLine(matematik.Çıkarma(user, user2));  }
            //else if (i == "/") { Console.WriteLine(matematik.Bölme(user, user2));}
            //else if (i == "*") { Console.WriteLine(matematik.Çarpma(user, user2)); }

            Console.Write("Fiyat giriniz \n>>>>");
            double user = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ders.get_kdv(user));

            //try
            //{
            //    Console.Write("hız giriniz \n>>>>");
            //    int user = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("zaman giriniz \n>>>>");
            //    int user2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(ders.get_fast(user, user2));
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Fuck you");
            //}

            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 1; j < 11; j++)
            //    {
            //        Console.WriteLine(i+"x"+j + "="+(i*j));

            //    }

            //}


            Console.ReadKey();

        }
        
    }

    
}
