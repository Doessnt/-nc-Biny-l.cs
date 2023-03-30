using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User's password
            int password = 35921;
            int bakiye = 250;

            string text = @"
                 ____       _______ _____ _  __  ____          _   _ _  __
                |  _ \   /\|__   __|_   _| |/ / |  _ \   /\   | \ | | |/ /
                | |_) | /  \  | |    | | | ' /  | |_) | /  \  |  \| | ' / 
                |  _ < / /\ \ | |    | | |  <   |  _ < / /\ \ | . ` |  <  
                | |_) / ____ \| |   _| |_| . \  | |_) / ____ \| |\  | . \ 
                |____/_/    \_\_|  |_____|_|\_\ |____/_/    \_\_| \_|_|\_\" + "\n";

            // Seçim 1 ana menü
            string s1_main_menü = @"
            Para Çekmek için    1
            Para yatırmak için  2
            Para Transferleri   3
            Eğitim Ödemeleri    4
            Ödemeler            5
            Bilgi Güncelleme    6"+"\n>>>>";


        atm_page:
            Console.WriteLine(text);
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz\n1 --> Kartla işlem\n2 --> Kartsız işlem\n0 --> Çıkış\n>>>>");
            int atm = Convert.ToInt32(Console.ReadLine());
            if(atm == 1)
            {
                int have = 0;
                while (have <= 3)
                {
                    Console.WriteLine("Lütfen şifrenizi giriniz\n>>>>");
                    int user_password = Convert.ToInt32(Console.ReadLine());
                    if(user_password == password) { break; }
                    else if(have == 3) { Console.WriteLine("Hakkınız kalmadı ana menüye gidiyorsunuz"); goto atm_page; }
                    else { have++; }
                }
            main_page:
                Console.WriteLine(s1_main_menü);
                int user = Convert.ToInt32(Console.ReadLine());
                //s1.1
               
                
               

            }
            else if (atm == 2) {}
            else { Environment.Exit(0); }

            Console.ReadLine();
        }
    }
}
