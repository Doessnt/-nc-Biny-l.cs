using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ARRAYS 
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int[] numbers2 = {};
            int[] numbers3 = new int[10];
           
            long[] numbers = { 35, 21, 31, 62, 69, 78, 100  };
            //Console.WriteLine(numbers[0]);

            for (int i = 0; i <numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
             */

            //long[] numbers = { 35, 21, 31, 62, 69, 78, 100 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Array.Clear(numbers,1,2);
            //Console.WriteLine("Silindi");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //INDEXOF
            //int[] numbers = { 35, 21, 31, 62, 69, 78, 100 };
            //Console.WriteLine(Array.IndexOf(numbers,25));


            ////SHORT
            //int[] numbers = { 35, 21, 31, 62, 69, 78, 100 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("after short");
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            int[] dizi = { 89, 45, 68};
            //Array.Sort(dizi);
            //Array.Reverse(dizi);
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //Array.Sort(dizi);
            //for (int i = dizi.Length-1; i >= 0 ; i--)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //RESIZE
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-----------------");

            //Array.Resize(ref dizi, 4);
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //dizi[3] = 10;
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            //Console.ReadKey();
            //int[] array = new int[3];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("sayılar");
            //    int j = Convert.ToInt32(Console.ReadLine());
            //    array[i] = j;
            //}
            //for (int i = 0; i <array.Length ; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //Console.Write("KAÇ KİŞİSİNNİZ\n>>>>");
            //int user1 = Convert.ToInt32(Console.ReadLine());

            //string[] family = new string[user1];

            //for (int i = 0; i < family.Length; i++)
            //{
            //    Console.Write("Aile fertlerinin ismi\n>>>>");
            //    string member = Console.ReadLine();
            //    family[i] = member;

            //}
            //for (int i = 0; i < family.Length; i++)
            //{
            //    Console.Write("ALİLEN BU AMK İSTE\n{0}", family[i]);

            //}

            int tekler = 0;
            int çiftler = 0;
            int[] sayilar = { 12, 32, 45, 19, 21, 18 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if(sayilar[i] % 2 == 0)
                {
                    Console.WriteLine(sayilar[i]);
                    çiftler = çiftler += sayilar[i];
                    
                }
                else
                {
                    Console.WriteLine(sayilar[i]);
                    tekler = tekler +=sayilar[i];

                }
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine(çiftler);
            Console.WriteLine(tekler);



            Console.ReadKey();
        }
    }
}
