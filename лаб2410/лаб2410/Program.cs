using System;
using System.Collections.Generic;

namespace лаб2410
{
    class Student
    {
        public string Name { get; set; }
        public string Section { get; set; }

        public Student(string name, string section)
        {
            Name = name;
            Section = section;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Иванов", "Секция A"));
            students.Add(new Student("Петров", "Секция B"));
            students.Add(new Student("Сидоров", "Секция A"));
            students.Add(new Student("Смирнов", "Секция C"));

            Console.WriteLine("Список студентов:");
            foreach (Student student in students)
            {
                Console.WriteLine("Имя: " + student.Name + ", Секция: " + student.Section);
            }

            Console.WriteLine("\nПоследовательность выступающих:");
            int index = 1;
            foreach (Student student in students)
            {
                Console.WriteLine(index + ". " + student.Name);
                index++;
            }

            Console.ReadLine();
        }
    }
}
