using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool Prime(int n)   //проверям простое ли число
        {
            bool ok = true;
            if (n == 1)
            {
                ok = false;
            }
            if (n == 2)
            {
                ok = true;
            }
            else
            {
                for (int i = 2; i < n; i++) {    //пробегаемся по элемнтам
                    if (n % i == 0)     //если данное число делится на определенные числа до того числа
                    {
                        ok = false;   //то это число не простое
                        break;
                    }
            }
        }
        return ok;   //выводим результат переменной
        } 
        static bool Prime(string s)  //так как число принимается в string-овом значении
        {
            return Prime(int.Parse(s));  //превращаем его в int-овое значение
        }
        static void Main(string[] args)
        {
            List<string> result = new List<string>();   //создаем динамичный массив, так как программа не знает сколько чисел будет задано
            FileStream file = new FileStream(@"C:\Users\Acer\Desktop\Solutions\Prime.txt", FileMode.Open, FileAccess.Read); //открываем и читаем файл
            StreamReader sr = new StreamReader(file);  //позволяет прочитать содержимое файла
            string line = sr.ReadLine();  //заводим неопределенное количество чисел
            string[] nums = line.Split();   //делим эти числа через пробел и добавляем в массив
            foreach (var a in nums)  //пробегаемся по этим элементам
            {
                if (Prime(a))    //если это число будет простым
                {
                    result.Add(a);  //то добавялем его в динамичный массив
                }
            }
            sr.Close();   //закрываем файлы
            file.Close();

            FileStream fileanswer = new FileStream(@"C:\Users\Acer\Desktop\Solutions\answer.txt", FileMode.CreateNew, FileAccess.Write);  //создаем новый файл
            StreamWriter sw = new StreamWriter(fileanswer);  //позволяет написать в файл то, что надо
            foreach (var a in result)   //пробемгаемся по элементам, которые добавили в динамичный массив
            {
                sw.Write(a + " ");   //записываем эти числа в файл
                Console.Write(a + " ");  //Выводим эти же числа на консоль
            }
            sw.Close();    //закрываем файлы
            fileanswer.Close();
        }
    }
}
