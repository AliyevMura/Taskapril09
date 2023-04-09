
using System;
using System.Net.Cache;
using System.Text;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student("Ali", "Seferli", "AB201", 15, false),
                new Student("Muslum", "Misirli", "AB201", 75, false),
                new Student("Murad", "Aliyev", "AB201", 90, true),
                new Student("Malak", "Mansimova", "AB201", 60, false),
                new Student("Nigar", "Mammadova", "AB201", 95, true)
            };

            ShowInfo(students);
            Console.ReadLine();
        }

        public static void ShowInfo(Student[] students)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var student in students)
            {
                sb.AppendLine(student.StudentInfo());
            }

            Console.WriteLine(sb.ToString());
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public int Point { get; set; }
        public bool IsGraduated { get; set; }

        public Student(string name, string surname, string group, int point, bool isGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = isGraduated;


        }

        public string FullName()
        {
            return $"{Name} {Surname}";
        }

        public bool Exam()
        {
            if (Point > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string StudentInfo()
        {
            string graduationstatus = IsGraduated ? "Mezun oldu" : "Mezun olmadi";
            return $"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point}, {graduationstatus}";
        }
    }
}



