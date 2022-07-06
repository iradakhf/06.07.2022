using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Class1
    {


        public string name = "";
        public string surname = "";
        public int age;
        public string gender = "";
        public int gpa;
        public Class1()
        {
            Console.WriteLine("edfault worked");
        }
        public Class1(string name, string surname, string gender, int age, int gpa) : this()
        {

            this.name = name;
            this.surname = surname;
            this.age = age;
            this.gender = gender;
            this.gpa = gpa;
            Console.WriteLine("Custom worked");

        }

        public string StudentsDetails()
        {
            return $"{name} {surname} {age} {gender} {gpa}";
        }
    }

}
