using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// string[] Names = new string[3];
            //string[] Names = { "ahmet", "hitler", "stalin" };


            //ArrayList arr = new ArrayList();
            //arr.Add("Altan");
            //arr.Add(12);
            //arr.Add("Hitler");
            //arr.Add(12.9f);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            ArrayList arr = new ArrayList();
            
            Random r = new Random();
            for (int i = 0; i <= 10; i++)
            {
                arr.Add(r.Next(1, 10));
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
