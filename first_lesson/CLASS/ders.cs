using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    internal class ders
    {
        public static int hesapla()
        {
            Console.Write("Ilk sayiyi giriniz\n>>>>");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci sayiyi giriniz\n>>>>");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = number2 + number1;
            return result;
        }
        public static string get_message()
        {
            return "HEIL HITLER";
        }
        public static int get_age()
        {
            int result = 0;

            int i = 0;
            while (true)
            {


                Console.Write("Ikinci sayiyi giriniz\n>>>>");
                int number2 = Convert.ToInt32(Console.ReadLine());
                if (number2 == 999) { break; }
                result = result += number2;
                i++;
            }
            result = result / i;
            return result;
        }
        public static double get_kdv(double user){


            return (user * 0.75);
        }
        public static int get_fast(int user, int user2)
        {
            try
            {
                return user * user2;
            }
            catch (Exception)
            {
                return 0;
                
            }
            
        }
        

    }
}
