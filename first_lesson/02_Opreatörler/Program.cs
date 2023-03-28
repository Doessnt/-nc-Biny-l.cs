using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Opreatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Aritmatik Operatörler(+,-,*,/,%)
             */
            //int i = 3 * 5 / 7;
            //int j = 3*(6/7);
            //int k = 3 % 2;
            //Console.WriteLine(i,j,k);
            //Console.WriteLine(i);
            //Console.WriteLine(j);
            //Console.WriteLine(k);
            //Console.ReadKey();

            ///////////////////////////

            //float i = 5 / 2f;
            //float j = 2 / 5 / 2f;
            //float k = 2f / 5 / 2;
            //Console.WriteLine(i);
            //Console.WriteLine(j);
            //Console.WriteLine(k);
            //Console.ReadKey();

            //int a = 5;
            //int i = ++a;
            //Console.WriteLine(i+" "+a);

            /* Mantıksak Operatörler
               *AND = &&
               *OR = ||
               *NOT = !
               
            &&
            username && password = Result
              F            F         F
              F            T         F
              T            F         F
              T            T         T
              
             ||
             username || password = Result
                F           F         F
                F           T         T
                T           F         T
                T           T         T
             
            !
            bool result = 3 > 2;
            sounc !
            string username_data = "a";
            string password_data = "";


            Console.Write("Username \n>>>>");
            string username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Password\n>>>>");
            string password = Console.ReadLine();
            bool result = username == username_data && password == password_data;
            



            Console.Write(username);
            Console.Write(password);
            Console.Write(result);
           

            string user_name = "hitler";
            string user_email = "stalingrad@hitler.com";
            string password = "hitler";
            Console.Write("Username or Email\n>>>>");
            string user_input = Console.ReadLine();
            Console.Clear();
            Console.Write("Password\n>>>>");
            string user_password = Console.ReadLine();



            bool result = (user_input == user_name || user_input == user_email) && user_password == password ;
            Console.Write(result);
            *** ATAMA OPERATÖRLERİ ***
            int sayi = 5;
            
            sayi = sayi + 1;
            // same 
            sayi += 1;
            sayi -= 1;
            sayi *= 1;
            sayi /= 1;
            
            *** KIYAS OPERATÖRÜ***

            int s1 = 4;
            int s2 = 5;
            Console.WriteLine(s1==s2?"Eşittir":"EŞİT DEĞİLDİR");
            //                     if  TRUE        FALSE
            
            *** Karşılaştırma OP'S ***
            > büyük
            < küçük
            <= küçük veya eşit
            >= büyük veya eşit
            != eşit değil 
            == eşittir
             */




            Console.ReadLine();




        }
    }
}
