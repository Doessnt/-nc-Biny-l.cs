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
        public bool ismerried;

        public static void Kayıt(List<Teacher> list)
        {
            Teacher teacher = new Teacher();
            teacher.TeacherName = "Adolf";
            teacher.TeacherSurname = "Hitler";
            teacher.TeacherAge = 31;
            teacher.TeacherType = "Painting";
            teacher.ismerried = true;
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
                Console.WriteLine(teacher.ismerried);
                

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


    }
   
}
