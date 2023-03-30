using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ürünler = { "Kola", "Bisküvi","Çikolata" };
            int[] fiyatlar = { 7, 3, 2 };
           main_menü:
            Console.WriteLine("Admin/Kullancı'mı olarak giriceksiniz ? \nAdmin -> 1\nÜye -> 2");
            int user = Convert.ToInt32(Console.ReadLine());
            if(user == 1){
                
                for (int i = 0; i < ürünler.Length; i++) // Ürünler fiyatlandırıldı.
                {
                    Console.WriteLine(i +" "+ ürünler[i] + " " + fiyatlar[i] +" "+ "TL");
                }
             // Ürün fiyat güncelleme
             admin_main_menü:
                Console.Write("Lütfen Değiştirmek istediğiniz ürünü seçin(Ana menü için '5' )\n>>>>");
                int user1 = Convert.ToInt32(Console.ReadLine());
                if (user1 == 5)
                {
                    goto main_menü;
                }
                Console.WriteLine("Lütfen değiştirmek istediğiniz fiyatı giriniz(Şuandaki fiyat {0})", fiyatlar[user1]);
                int user_change = Convert.ToInt32(Console.ReadLine());
                fiyatlar[user1] = user_change;
                Console.Write("Değiştirildi..\t Şuanki güncel liste\n");
                for (int i = 0; i < fiyatlar.Length; i++)
                {
                        Console.WriteLine(i + " " + ürünler[i] + " " + fiyatlar[i] + " " + "TL");


                }
                goto admin_main_menü;
                
                
            }



            Console.ReadKey();
        }
    }
}
