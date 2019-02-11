using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name;
        public string id;
        public int year; 
        public Student(string n, string i) //constructor 
        {
            name = n;
            id = i;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"name = {name} id = {id}");
        }
    }
    class Program
    {
        public static void Increment(int year)
        {
            year++; 
             Console.WriteLine(year);
        }
        static void Main(string[] args)
        {
            Student s = new Student("Assem", "1235009");
            s.PrintInfo();
          Console.WriteLine($"Next year of study is: ");
            Increment(1);
         }
    }
}
