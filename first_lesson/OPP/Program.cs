using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Büyük çaplı projeler için geliştirmeye yarar. Web, Mobil, Oyun, Desktop vb 

             * 4 Temelden oluşur
                 * Inheritance 
                 * Encapsultaion
                 * Polymorphism
                 * Abstraction
             */



            //Musteri m = new Musteri();
            //m.ad = "Adolf hitler";
            //m.tc = 0101010101011001;
            //m.bakiye = 9999999999999;
            //m.hesapno = "1845"; 
            //krediHesabı hesap = new krediHesabı();
            //hesap.KartSahibi = "Adolf Hitler";
            //hesap.limit = 50000000.0;
            //hesap.hesapno = 11111111111;

            //krediHesabı hesap2 = new krediHesabı();
            //hesap.KartSahibi = "Stalin";
            //hesap.limit = 100.0;
            //hesap.hesapno = 11111211111;

            //List<krediHesabı> hesaplar = new List<krediHesabı>();
            //hesaplar.Add(hesap);
            //hesaplar.Add(hesap2);

            //for (int i = 0; i <= 2; i++)
            //{
            //    krediHesabı h = new krediHesabı();
            //    Console.WriteLine("Kartsahibi");
            //    h.KartSahibi = Console.ReadLine();
            //    Console.WriteLine("limit");
            //    h.limit = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Hesap no:");
            //    h.hesapno = Convert.ToInt64(Console.ReadLine());

            //    hesaplar.Add(h);
            //}

            //List<Ogrenci> students = new List<Ogrenci>();   
            //for (int i = 0; i < 3; i++)
            //{
            //    Ogrenci student = new Ogrenci();
            //    Console.WriteLine("Name");
            //    student.name = Console.ReadLine();
            //    Console.WriteLine("Id");
            //    student.ıd = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("CLASS");
            //    student.Class = Console.ReadLine();
            //    students.Add(student);
            //}
            //for (int i = 0; i < students.Count; i++)
            //{
            //    Console.WriteLine(students[i].ıd);
            //    Console.WriteLine(students[i].name);
            //    Console.WriteLine(students[i].Class);


            //}
            //Console.WriteLine("Done");

            //Ogrenci ogr1 = new Ogrenci()
            //{
            //    Class = "7/A",
            //    name = "Adolf",
            //    ıd = 912
            //};
            //Ogrenci ogr2 = new Ogrenci()
            //{
            //    Class = "7/A",
            //    name = "HITLER",
            //    ıd = 911
            //};
            //Ogrenci ogr3 = new Ogrenci()
            //{
            //    Class = "7/A",
            //    name = "STALIN",
            //    ıd = 911
            //};
            //List<Ogrenci> list = new List<Ogrenci>();
            //Console.WriteLine("iSTEDİĞİNZ ÖĞRENCİNİN NO:");
            //int ıd = Convert.ToInt32(Console.ReadLine());
            //foreach (var item in list )
            //{
            //    if(item.ıd == ıd)
            //    {
            //        Console.WriteLine(item.name, item.Class, item.ıd);
            //    }

            //}

            //List<Ogrenci> students = new List<Ogrenci>();

            //Ogrenci.Register(students);

            //Ogrenci.print_list(students);
                        
            List<Teacher> list = new List<Teacher>();
            Teacher.Kayıt(list);
            Teacher.write(list);
            Teacher.Kayıt(list);
            Teacher.delete(list);



            Console.ReadKey();
        }
        
    }
}
