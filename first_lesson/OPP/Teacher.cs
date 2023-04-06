using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    internal class Teacher
    {
        public string TeacherName;
        public string TeacherSurname;
        public string TeacherType;
        public int TeacherAge;
       

        public static void Kayıt(List<Teacher> list)
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("Ad");
            teacher.TeacherName = Console.ReadLine();
            Console.WriteLine("Soyad");
            teacher.TeacherSurname = Console.ReadLine();
            Console.WriteLine("Yaş");
            teacher.TeacherAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Branş");
            teacher.TeacherType =  Console.ReadLine();
           
            list.Add(teacher);
        }
        public static void write(List<Teacher> list)
        {
            foreach (Teacher teacher in list)
            {
                Console.WriteLine(teacher.TeacherName);
                Console.WriteLine(teacher.TeacherSurname);
                Console.WriteLine(teacher.TeacherAge);
                Console.WriteLine(teacher.TeacherType);
               
                

            }
        }
        public static void delete(List<Teacher> list)
        {
            Console.WriteLine("www");
            string user = Console.ReadLine();
            foreach (Teacher teacher in list)
            {
                if (teacher.TeacherName == user)
                {
                    list.Remove(teacher);
                    break;
                }
            }
            if(list.Count == 0)
            {
                Console.WriteLine("Listede eleman kalmadı");
            }
            else {write(list);}
            
        }
        public void Update(List<Teacher> list)
        {
             write(list);
            Console.WriteLine("Güncellenecek");
            string name  = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].TeacherName == name)
                {

                    Console.WriteLine("Değiştir lan branşı");
                    list[i].TeacherType = Console.ReadLine();

                }
            }

        }


    }
    class Car {


        public string CarColor;
        public string speed;
        public string DoorCount;
       


        public static void Ekle(List<Car> list)
        {
            Car car = new Car();
            Console.WriteLine("What's the Car's color");
            car.CarColor = Console.ReadLine();
            Console.WriteLine("What's the car's speed");
            car.speed = Console.ReadLine();
            Console.WriteLine("How many door hav the car");
            car.DoorCount = Console.ReadLine();
            

            list.Add(car);
        }
        public static void write(List<Car> list)
        {
            foreach ( Car item in list)
            {
                Console.WriteLine(item.CarColor);
                Console.WriteLine(item.speed);
                Console.WriteLine(item.DoorCount);
               

            }
        }
        public static void delete(List<Car> list)
        {
            Console.WriteLine("www");
            string user = Console.ReadLine();
            foreach (Car car in list)
            {
                if (car.CarColor == user)
                {
                    list.Remove(car);
                    break;
                }
            }
            if (list.Count == 0)
            {
                Console.WriteLine("Listede eleman kalmadı");
            }
            else { write(list); }

        }
        public static void Update(List<Car> list)
        {
            write(list);
            Console.WriteLine("Güncellenecek");
            string name = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CarColor == name)
                {

                    Console.WriteLine("Değiştir lan branşı");
                    list[i].speed = Console.ReadLine();

                }
            }

        }











    }
}
