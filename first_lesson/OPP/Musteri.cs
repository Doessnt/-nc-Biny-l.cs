using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    internal class Musteri
    {
        public string ad;
        public long tc;
        public double bakiye;
        public string hesapno;

        public static void yaz()
        {
            Console.WriteLine("Welcome to Lospollos Hermanos Family");
        }



    }
    public class Ogrenci {
        public string name;
        public int ıd;
        public string Class;
        public static void Register(List<Ogrenci> list) {
            Ogrenci student = new Ogrenci();
            Console.WriteLine("Name:");
            student.name = Console.ReadLine();
            Console.WriteLine("ıd");
            student.ıd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Class");
            student.Class = Console.ReadLine();
            list.Add(student);

        }
        public static void print_list (List<Ogrenci> list){
            foreach (Ogrenci item in list)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.ıd);
                Console.WriteLine(item.Class);

            }

        }
    }
    class krediHesabı
    {
        public long hesapno;
        public double limit;
        public string KartSahibi;

    }
}
