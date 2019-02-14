using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student   //создаем класс 
    {       //Описанием объекта является класс, а объект представляет экземпляр этого класса
        public string name;
        public string id;
        public int year; 
        public Student(string n, string i) //constructor Конструкторы вызываются при создании нового объекта данного класса. 
        {                                  //Конструкторы выполняют инициализацию объекта.
            name = n;
            id = i;
        }

        public void PrintInfo()          //метод, который выводит имя и ID студента
        {
            Console.WriteLine($"name = {name} id = {id}");
        }
    }
    class Program
    {
        public static void Increment(int year)  //метод, который инкрементирует год обучения
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
