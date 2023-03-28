using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Adınız\n>>>>");
            //string ad = Console.ReadLine();
            //Console.WriteLine(ad);

            //string deger = "12";
            //int yas = Convert.ToInt32(deger);

            //Console.Write("number1\n>>>>");
            //int nb1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("number2\n>>>>");

            //int nb2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("number3\n>>>>");

            //int nb3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(nb1 + nb2+ nb3);

            int yas = 34;
            string y = yas.ToString();
            Console.WriteLine(y);
            Console.Write(yas.GetType());
            Console.WriteLine(y.GetType());


            Console.ReadKey();

        }
    }
}
