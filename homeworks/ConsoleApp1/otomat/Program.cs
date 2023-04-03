using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ürünler = { "Kola", "Bisküvi", "Çikolata" };
            int[] fiyatlar = { 7, 3, 2 };

            Console.WriteLine("Admin/Kullancı'mı olarak giriceksiniz ? \nAdmin -> 1\nÜye -> 2");
            int user = Convert.ToInt32(Console.ReadLine());
            if(user == 1)
            {
                Admin.listProducts(ürünler, fiyatlar);
                Admin.checkPrices(ürünler, fiyatlar);
            }
            else if (user == 2)
            {
                Console.WriteLine("---Hoşgeldiniz---");
                Admin.custemer_mechanic(ürünler, fiyatlar);

            }






            Console.ReadKey();
        }
    }
}
