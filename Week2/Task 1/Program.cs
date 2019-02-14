using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        public static bool Palindrome(string str) //Проверка на палиндром
        {
            bool ans = true;
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] != str[str.Length - i - 1])  //условно: если первый элемент не равняется последниму 
                {
                    ans = false;                       //тогда это не палиндром
                    break;
                }
            }
            return ans;    //возвращаем итоговый ответ проверки
        }
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\Users\Acer\Desktop\Solutions\Palindrome.txt", FileMode.Open, FileAccess.Read); //открываем и чтаем файл
            StreamReader sr = new StreamReader(file);  //позволяет считывать файл
            string text = sr.ReadToEnd();  //считываем запись в файле до конца
            if (Palindrome(text) == true)   //проверяем на палиндром
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            sr.Close();    //закрываем файлы
            file.Close();
        }
    }
}
