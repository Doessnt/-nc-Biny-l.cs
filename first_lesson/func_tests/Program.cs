using System;

namespace func_tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bruh");
            //int user = Convert.ToInt32(Console.ReadLine());
            //RTE(user);
            //Console.ReadKey();
            //Console.WriteLine("1.item");
            //int user1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.item");
            //int user2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("3.item lamak istemsiiniz y/n");
            //string user3 = Console.ReadLine();
            //if (user3 == "y")
            //{
            //    Console.WriteLine("3.item");
            //    double user4 = Convert.ToInt64(Console.ReadLine());
            //    indrim(user1, user2, user4);
            //}



















            Console.ReadKey();
        }
        static void RTE(int i)
        {
            Console.WriteLine("Kdv niz " + (i * 1.18));
        }
        static void indrim(double user1, double user2, double user3)
        {
            if (user1 > user2)
            {
                double result = (user1 * 0.70);
                Console.WriteLine(user1 - result);
            }
            else if (user1 < user2)
            {
                double result = (user2 * 0.70);
                Console.WriteLine(user2 - result);
            }
            else if (user3 != 0)
            {
                double result = (user3 * 0.50);
                Console.WriteLine(user3 - result);
            }

        }


    }
}
