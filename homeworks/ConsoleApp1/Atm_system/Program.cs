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
            Bilgi Güncelleme    6" + "\n>>>>";
            // Para yatırma menüsü

            string s1_deposit = @"
            Kredi Kartına   1
            Kendi Hesabınıza yatırmak için  2
            Ana Menü        9
            Çıkmak için     0";



        atm_page:
            Console.WriteLine(text);
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz\n1 --> Kartla işlem\n2 --> Kartsız işlem\n0 --> Çıkış\n>>>>");
            int atm = Convert.ToInt32(Console.ReadLine());
            if (atm == 1)
            {
                int have = 0;
                while (have <= 3)
                {
                    Console.WriteLine("Lütfen şifrenizi giriniz\n>>>>");
                    int user_password = Convert.ToInt32(Console.ReadLine());
                    if (user_password == password) { break; }
                    else if (have == 3) { Console.WriteLine("Hakkınız kalmadı ana menüye gidiyorsunuz"); goto atm_page; }
                    else { have++; }
                }
            main_page:
                Console.WriteLine(s1_main_menü); // Ana menü
                int user = Convert.ToInt32(Console.ReadLine());
                if (user == 1)// Para Çekme
                {
                withdraw_money: // Para çekme işlemi
                    Console.Write("Lütfen çekmek istediğiniz tutarı giriniz\n>>>>");
                    int user01 = Convert.ToInt32(Console.ReadLine());//Kişinin atmden istediği para
                    if (user01 > bakiye)
                    { // Eğer fazla bir tutar girerse
                        Console.Write("Malesef bukardar bakiyeniz yok");
                        goto withdraw_money;
                    }
                    else
                    {
                        bakiye = bakiye - user01;
                        Console.WriteLine("Çekme işlemi başarılı bir şekilde uygulandı şuan ki kalan bakiyeniz\n" + bakiye + "TL");
                        Console.WriteLine("Başka bir işlem yapmak istermisiniz ? Y/N");
                        char yn = Convert.ToChar(Console.ReadLine().ToLower());
                        if (yn == 'y') { goto main_page; }
                        Environment.Exit('n');
                        // Para çekme işlemi bitti
                    }

                } // Para Çekme
                else if(user == 2)// Para yatırma
                {
                    Console.WriteLine(s1_deposit);
                    int user01 = Convert.ToInt32(Console.ReadLine());
                 deposit:
                    if(user01 == 1)//Karta para yatırma
                    {
                        Console.Write("Lütfen 12 Haneli kart numarasını giriniz\n>>>>");
                        long user02 = Convert.ToInt64(Console.ReadLine()); // Paranın yatırılacağı kredi kartı numarası
                        Console.Write("Göndermek istediğniz parayı yazın\n>>>>");
                        int user03 = Convert.ToInt32(Console.ReadLine()); // Kredi kartına yatıcak olan para
                        if (user03 > bakiye) { Console.WriteLine("Bakiyeniz yetersiz ana menüye gidiyorsunuz\n"); goto deposit; }
                        else
                        {
                            bakiye = bakiye - user03;
                            Console.WriteLine("İşleminiz başarı ile gerçekleştirildi\nŞuan ki güncel bakiyeniz " + bakiye);
                            Console.WriteLine("Başka bir işlem yapmak istermisiniz ? Y/N");
                            char yn = Convert.ToChar(Console.ReadLine().ToLower());
                            if (yn == 'y') { goto main_page; }
                        }
                        
                    }

                }




            }
            else if (atm == 2) { }
            else { Environment.Exit(0); }

            Console.ReadLine();
        }
    }
}
