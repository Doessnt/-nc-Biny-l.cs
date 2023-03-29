using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*WHİLE
             int counter = 0;
             while(i<10){
                Console.WriteLine(i);
                i++;
            
            }
            */

            //int i = 250;
            //while (i >= 0)
            //{
            //    if(i%11 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i--;
            //}

            //Console.ReadKey();

            /*FOR
             
             
             */
            //for (int i = 1; i < 500; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}

            //int a = 0;
            //for (int i = 1; i < 500; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        a = a + i;
            //        Console.WriteLine(a);

            //    }
            //}

            //Console.WriteLine("Adet\n>>>>");
            //int user1 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //for (int i = 0; i < user1; i++)
            //{
            //    Console.WriteLine("Fiyatları giriniz\n>>>>");
            //    int user2 = Convert.ToInt32(Console.ReadLine());
            //    toplam = toplam + user2;
            //}
            //Console.WriteLine(toplam);

            //int j = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    j += i;


            //}
            //Console.WriteLine(j);

            //Random rnd = new Random();
            //int j = 5;
            //int number = rnd.Next(1, 10);
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Sayı tahimni\n>>>>");
            //    int user = Convert.ToInt32(Console.ReadLine());
            //    if(user == number)
            //    {
            //        Console.WriteLine("DOĞRU");
            //        break;
            //    }
            //    else if (i == 5)
            //    {
            //        Console.WriteLine("Hakkın bitti sayı\t" + number + "\t idi.");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Yanlış tahmin kalan hakkınız" + (j - i));

            //    }


            //}
            
            
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Lütfen isim");
                string user_name = Console.ReadLine().ToLower();
                Console.WriteLine("PASSWORD");
                string user_password = Console.ReadLine().ToLower();
                int j = 3;
                if (user_name == "admin" && user_password == "admin")
                {
                    Console.WriteLine("Hoşgeldiniz");
                    break;
                }
                else if (i == 3) {
                    Console.WriteLine("FUCK OFF");
                }
                else
                {
                    Console.WriteLine("YANLIŞ KALAN HAKKINIZ" + (j-i));
                }
                
            }


            Console.ReadKey();

        }
    }
}
