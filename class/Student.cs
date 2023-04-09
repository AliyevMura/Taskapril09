//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task09
//{
//    class Student
//    {
//        public Student()
//        {
//            Console.WriteLine("murad");
//        }

//        public Student(string name)
//        {
//            this.name = name;
//        }


//        public Student(string name, string surname) : this(name)
//        {

//            this.surname = surname;
//        }


//        public Student(string name, string surname, int age) : this(name, surname)
//        {

//            this.age = age;
//        }

//        public Student(string name, string surname, int age, string Group) : this(name, surname, age)
//        {

//            this.Group = Group;
//        }


//        public Student(string name, string surname, int age, string Group, int point) : this(name, surname, age, Group)
//        {

//            this.point = point;
//        }



//        public Student(string name, string surname, int age, string Group, int point, bool IsGraudated) : this(name, surname, age, Group, point)
//        {

//            this.IsGraudated = IsGraudated;
//        }

//        public string name;
//        public string surname;
//        public int age;
//        public string Group;
//        public int point;
//        public bool IsGraudated;


//        public void ShowInfo()
//        {
//            Console.WriteLine($"{name}  {surname} {age} {Group} {point} {IsGraudated}");
//        }
//    }


//}

