using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomat
{
    internal class Admin
    {
        public static void listProducts(string[] products,int[] prieces )
        {
            for(int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(i + " " + products[i] + " " + prieces[i] + " " + "TL");
            }

        }
        public static void checkPrices(string[] products, int[] prices)
        {
            Console.Write("Lütfen Değiştirmek istediğiniz ürünü seçin(Ana menü için '5' )\n>>>>");
            int user = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen değiştirmek istediğiniz fiyatı giriniz(Şuandaki fiyat {0})", prices[user]);
            int user_change = Convert.ToInt32(Console.ReadLine());
            prices[user] = user_change;
            Console.Write("Değiştirldi...\nGüncel liste\n");
            listProducts(products,prices);

        }
        public static void customer_buy(string[] products, int[] prices, int user, int user_input)
        {
            int userr = prices[user];
            if (user_input < userr)
            {
                Console.WriteLine("Eksik para koydunuz\nLütfen tam fiyat değerinde para koyunuz");
            }
            else if (user_input > userr)
            {
                Console.WriteLine("Ürününüz verildi para üstünüz " + (user_input - userr) + "TL'dir");
            }
            else
            {
                Console.WriteLine("Ürününüz verildi");


            }

        }

        public static void custemer_mechanic(string[] products, int[] prices)
        {
            listProducts(products,prices);
            Console.WriteLine("Lütfen seçiminizi yapınız\n>>>>");
            int user = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen parayıgiriniz\n>>>>");
            int user_input = Convert.ToInt32(Console.ReadLine());
            user = prices[user];
            customer_buy(products, prices, user, user_input);
            
        }


    }
}
