using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void PrintInfo(FileSystemInfo fsi, int n)  //создаем метод который принимает параметры-файл/папка и число
        {
            string str = new string(' ', n);  //создаем строку, где пробел повторяется заданное количество раз
            Console.WriteLine(str + fsi.Name);   //выводим на консоль данную строку и Файл/Папку
            if (fsi.GetType() == typeof(DirectoryInfo))  //если это папка
            {
                FileSystemInfo[] array = ((DirectoryInfo)fsi).GetFileSystemInfos(); //cоздаем массив, куда добавляются папки
                for(int i=0; i<array.Length; i++)   
                {
                    PrintInfo(array[i], n + 5);   //выводим папки с n количеством пробелов + 5
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Acer\Desktop\Solutions");  //открываем папку
            PrintInfo(dir, 0);  //показывается содержимое этой папки; в начале количество пробелов было 0 (+5)
        }
    }
}
