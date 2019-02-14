using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\Users\Acer\Desktop\Solutions\path\original.txt", FileMode.CreateNew, FileAccess.Write); //Создаем файл
            StreamWriter sw = new StreamWriter(file); //позволяет записать что-то в файл
            sw.WriteLine("Hello world!"); //Записывает запись
            sw.Close();    //закрываем файлы
            file.Close();
            string fileName = "original.txt";   //называем файл
            string sourcePath = @"C:\Users\Acer\Desktop\Solutions\path";  //путь где лежит файл
            string targetPath = @"C: \Users\Acer\Desktop\Solutions\path1";   //путь где будет лежать новый файл
            string sourceFile = Path.Combine(sourcePath, fileName);  //соеденяем настоящий путь с именем файла
            string destFile = Path.Combine(targetPath, file.Name);  //соеденяем направленный путь с названием файла
            File.Copy(sourceFile, destFile, true);  //копируем данный файл в наст. пути в направленный путь и файл
            File.Delete(sourceFile);   //удаляем старый файл
            Console.WriteLine("DONE!"); //Выводит на консоль, что работа выполнена
        }
    }
}
