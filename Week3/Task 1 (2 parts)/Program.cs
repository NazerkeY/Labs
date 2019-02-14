using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Эскиз
{
    class FarManager
    {
        public int cursor;   // курсор
        public string path;   //путь
        public int sz;     //размер
        DirectoryInfo directory = null;  //папка
        FileSystemInfo currentFs = null; //файла

        public FarManager()   //метод, где курсор изначально равен нулю
        {
            cursor = 0;  
        }

        public FarManager(string path)
        {
            this.path = path;   //путь
            cursor = 0;   
            directory = new DirectoryInfo(path);  //создаем папку
            sz = directory.GetFileSystemInfos().Length; //выводим все содержимое папки
        }

        public void Color(FileSystemInfo fs, int index) //метод,который рисует
        {
            if (cursor == index) {

                Console.BackgroundColor = ConsoleColor.White; 

                Console.BackgroundColor = ConsoleColor.Red;
            currentFs = fs; }  
     else  if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;   //если папка
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;  //если файл
            }
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;  
            Console.Clear();
            directory = new DirectoryInfo(path); 
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            for (int i = 0, k = 0; i < fs.Length; i++)  //проходимся по содержанию
            {
                Color(fs[i], k); 
                Console.WriteLine((i + 1) + ". " + fs[i].Name); //выводим пронумеровав
                k++;
            }
        }
        public void Up()  //метод - курсор вверх
        {
            cursor--;
            if (cursor < 0)  
                cursor = sz - 1;
        }
        public void Down()  //метод - курсор вниз
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }
        public void Start() //метод клавиатуры
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();  
            while (consoleKey.Key != ConsoleKey.Escape)  //пока не вышли из программы
            {
                Show(); //покраска
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow) 
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))  //если мы в папке
                    {
                        cursor = 0;
                        path = currentFs.FullName; //то сохраняем путь
                    }
                    else
                    {
                        FileStream fs = new FileStream(currentFs.FullName, FileMode.Open, FileAccess.Read); //открываем папку
                        StreamReader sr = new StreamReader(fs); //для чтения
                        Console.BackgroundColor = ConsoleColor.White; 
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine(sr.ReadToEnd()); //содержимое файла выводим на консоль
                        Console.ReadKey();
                    }
                }
                if (consoleKey.Key == ConsoleKey.Delete) 
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))  
                    {
                        Directory.Delete(currentFs.FullName, true);  
                    }
                    else
                    {
                        File.Delete(currentFs.FullName);
                    }
                }
         /*     if (consoleKey.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("Please enter the new name, to rename {0}:", currentFs.FullName);
                    string newname = Console.ReadLine();
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                    new DirectoryInfo(currentFs.FullName).MoveTo(path + newname);
                    }
                    else
                    {
                        new FileInfo(currentFs.FullName).MoveTo(path + newname);
                    }
                } */
                if (consoleKey.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    path = directory.Parent.FullName;
                 
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Acer\Desktop\Solutions"; //указываем путь
            FarManager farManager = new FarManager(path);  //вызываем метод
            farManager.Start();  //вызываем метод
        }
    }
}