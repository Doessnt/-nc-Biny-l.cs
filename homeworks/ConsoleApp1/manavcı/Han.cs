using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manavcı
{
    internal class Han
    {
        public static void han_menu()
        {
            string sebze_menü = @"
1- Domates
2- Biber
3- Patlıcan
0- Çıkış              
            "; 

            
            Console.WriteLine("*** Hana Hoşgeldin ***");
            Console.Write("Sebze almak için 'S', Meyve için 'M', Çımak için 'Ç'\n>>>>");
            string han_menü = Console.ReadLine().ToUpper();
            if(han_menü == "S") {
                user u = new user();
                Console.WriteLine(sebze_menü);
                int user = Convert.ToInt32(Console.ReadLine());
                if(user == 0) { exit();}
                else if(user == 1) {
                    Console.WriteLine("Kaç kilo almak istersiniz?:");
                    int user01 = Convert.ToInt32(Console.ReadLine());
                    u.domates = user01;
                    Console.WriteLine("Şu kadar kilo domates alındı."+u.domates);
                    han_menu();
                } // Domates
                else if(user == 2) {
                    Console.WriteLine("Kaç kilo almak istersiniz?:");
                    int user01 = Convert.ToInt32(Console.ReadLine());
                    u.biber = user01;
                    han_menu();

                } // Biber
                else if(user==3) {
                    Console.WriteLine("Kaç kilo almak istersiniz?:");
                    int user01 = Convert.ToInt32(Console.ReadLine());
                    u.patlıcan = user01;
                    han_menu();

                }//Patlıcan


            }
            else if(han_menü == "m")
            {
                user u = new user();
                Console.WriteLine(sebze_menü);
                int user = Convert.ToInt32(Console.ReadLine());
                if (user == 0) { exit(); }
                else if (user == 1)
                {
                    Console.WriteLine("Kaç kilo almak istersiniz?:");
                    int user01 = Convert.ToInt32(Console.ReadLine());
                    u.muz = user01;
                    Console.WriteLine("Şu kadar kilo domates alındı." + u.domates);
                    han_menu();
                } // Muz
                else if (user == 2)
                {
                    Console.WriteLine("Kaç kilo almak istersiniz?:");
                    int user01 = Convert.ToInt32(Console.ReadLine());
                    u.erik = user01;
                    han_menu();

                } // Erik
                else if (user == 3)
                {
                    Console.WriteLine("Kaç kilo almak istersiniz?:");
                    int user01 = Convert.ToInt32(Console.ReadLine());
                    u.elma = user01;
                    han_menu();

                }//Elma
            }
            else
            {
                exit();
            }


        }
        public static void exit() {Environment.Exit(0);}

    }
    internal class user{
        public int domates;
        public int biber;
        public int patlıcan;
        // Meyveler 
        public int muz;
        public int erik;
        public int elma;

    }


}
